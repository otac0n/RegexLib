//-----------------------------------------------------------------------
// <copyright file="RepetitionNode.cs" company="(none)">
//  Copyright © 2012 John Gietzen.
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
// </copyright>
// <author>John Gietzen</author>
//-----------------------------------------------------------------------

namespace RegexLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class RepetitionNode : RegexNode
    {
        private readonly RegexNode repeated;
        private readonly int min;
        private readonly int? max;
        private readonly bool eager;

        public RepetitionNode(RegexNode repeated, int min, int? max, bool eager)
        {
            if (repeated == null)
            {
                throw new ArgumentNullException("other");
            }

            if (min < 0)
            {
                throw new ArgumentOutOfRangeException("min");
            }

            if (max.HasValue && max < min)
            {
                throw new ArgumentOutOfRangeException("max");
            }

            this.repeated = repeated;
            this.min = min;
            this.max = max;
            this.eager = eager;
        }

        public override bool Equals(RegexNode other)
        {
            var repetition = other as RepetitionNode;
            return !object.ReferenceEquals(repetition, null) &&
                this.repeated == repetition.repeated &&
                this.min == repetition.min &&
                this.max == repetition.max &&
                this.eager == repetition.eager;
        }

        public override int GetHashCode()
        {
            int hash = 0x51ED270B;
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

        private bool WithinMinMax(int rep)
        {
            return rep >= this.min && (this.max == null || rep <= this.max);
        }

        private static RegexMatch ComposeMatch(string subject, int originalIndex, List<RegexMatch> subMatches)
        {
            var length = subMatches.Sum(m => m.Length);
            return new RegexMatch(subject, originalIndex, length, subMatches);
        }

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
            for (int i = 0; i < count; i++)
            {
                result.Append(this.repeated.GenerateString(rand));
            }

            return result.ToString();
        }
    }
}
