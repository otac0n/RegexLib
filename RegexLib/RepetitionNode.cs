// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace RegexLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class RepetitionNode : RegexNode
    {
        private readonly bool eager;
        private readonly int? max;
        private readonly int min;
        private readonly RegexNode repeated;

        public RepetitionNode(RegexNode repeated, int min, int? max, bool eager)
        {
            this.repeated = repeated ?? throw new ArgumentNullException(nameof(repeated));

            if (min < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(min));
            }

            if (max.HasValue && max < min)
            {
                throw new ArgumentOutOfRangeException(nameof(max));
            }

            this.min = min;
            this.max = max;
            this.eager = eager;
        }

        public override bool Equals(RegexNode other) =>
            other is RepetitionNode repetition &&
            this.repeated == repetition.repeated &&
            this.min == repetition.min &&
            this.max == repetition.max &&
            this.eager == repetition.eager;

        public override string GenerateString(Random rand)
        {
            int count;
            if (this.max.HasValue)
            {
                var range = this.max.Value - this.min;
                count = rand.Next(range + 1) + this.min;
            }
            else
            {
                count = this.min;
                while (rand.Next(2) == 0)
                {
                    count++;
                }
            }

            var result = new StringBuilder();
            for (var i = 0; i < count; i++)
            {
                result.Append(this.repeated.GenerateString(rand));
            }

            return result.ToString();
        }

        public override IEnumerator<string> GetEnumerator()
        {
            if (this.min == 0)
            {
                yield return string.Empty;
            }

            IEnumerator<string> repEnum = null;
            try
            {
                repEnum = this.repeated.GetEnumerator();
                var repList = new List<string>();
                var repActive = true;
                var maxBins = this.min;

                while (repActive || (!this.max.HasValue || maxBins < this.max))
                {
                    if (repActive = repActive && repEnum.MoveNext())
                    {
                        repList.Add(repEnum.Current);

                        for (var bins = Math.Max(1, this.min); bins <= maxBins; bins++)
                        {
                            var indices = new int[bins]; // TODO: Cache the allocation. Array.Clear(indices, 0, bins);

                            int ix;
                            do
                            {
                                if (indices.Any(i => i == repList.Count - 1))
                                {
                                    yield return string.Concat(Array.ConvertAll(indices, i => repList[i]));
                                }

                                ix = bins - 1;
                                while (ix >= 0 && ++indices[ix] >= repList.Count)
                                {
                                    indices[ix] = 0;
                                    ix -= 1;
                                }
                            }
                            while (ix >= 0);
                        }
                    }

                    if (repList.Count > 0)
                    {
                        if (maxBins < this.max)
                        {
                            maxBins++;

                            var indices = new int[maxBins]; // TODO: Cache the allocation. Array.Clear(indices, 0, maxBins);

                            int ix;
                            do
                            {
                                yield return string.Concat(Array.ConvertAll(indices, i => repList[i]));

                                ix = maxBins - 1;
                                while (ix >= 0 && ++indices[ix] >= repList.Count)
                                {
                                    indices[ix] = 0;
                                    ix -= 1;
                                }
                            }
                            while (ix >= 0);
                        }
                    }
                }
            }
            finally
            {
                if (repEnum is IDisposable disposable)
                {
                    disposable.Dispose();
                }
            }
        }

        public override int GetHashCode()
        {
            var hash = 0x51ED270B;
            hash = (hash * -0x25555529) + this.repeated.GetHashCode();
            hash = (hash * -0x25555529) + this.min.GetHashCode();
            hash = (hash * -0x25555529) + this.max.GetHashCode();
            hash = (hash * -0x25555529) + this.eager.GetHashCode();

            return hash;
        }

        protected override IEnumerable<RegexMatch> GetMatchesImpl(string subject, int index)
        {
            foreach (var blah in this.GetMatchesRecursive(0, subject, index, index, new List<RegexMatch>()))
            {
                yield return blah;
            }
        }

        private static RegexMatch ComposeMatch(string subject, int originalIndex, List<RegexMatch> subMatches)
        {
            var length = subMatches.Sum(m => m.Length);
            return new RegexMatch(subject, originalIndex, length, subMatches);
        }

        private IEnumerable<RegexMatch> GetMatchesRecursive(int rep, string subject, int originalIndex, int index, List<RegexMatch> subMatches)
        {
            if (this.max != null && rep > this.max)
            {
                yield break;
            }

            if (rep > this.min && rep > 1 && subMatches[subMatches.Count - 1].Length == 0)
            {
                yield break;
            }

            if (!this.eager && this.WithinMinMax(rep))
            {
                yield return ComposeMatch(subject, originalIndex, subMatches);
            }

            foreach (var m in this.repeated.GetMatches(subject, index))
            {
                subMatches.Add(m);

                foreach (var composite in this.GetMatchesRecursive(rep + 1, subject, originalIndex, index + m.Length, subMatches))
                {
                    yield return composite;
                }

                subMatches.RemoveAt(subMatches.Count - 1);
            }

            if (this.eager && this.WithinMinMax(rep))
            {
                yield return ComposeMatch(subject, originalIndex, subMatches);
            }

            yield break;
        }

        private bool WithinMinMax(int rep) => rep >= this.min && (this.max == null || rep <= this.max);
    }
}
