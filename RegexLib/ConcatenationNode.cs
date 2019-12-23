// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace RegexLib
{
    using System;
    using System.Collections.Generic;

    public class ConcatenationNode : RegexNode
    {
        private readonly RegexNode a;
        private readonly RegexNode b;

        public ConcatenationNode(RegexNode a, RegexNode b)
        {
            this.a = a ?? throw new ArgumentNullException(nameof(a));
            this.b = b ?? throw new ArgumentNullException(nameof(b));
        }

        public override bool Equals(RegexNode other) =>
            other is ConcatenationNode alternation &&
            this.a == alternation.a &&
            this.b == alternation.b;

        public override string GenerateString(Random rand) => this.a.GenerateString(rand) + this.b.GenerateString(rand);

        public override IEnumerator<string> GetEnumerator()
        {
            IEnumerator<string> aEnum = null;
            try
            {
                aEnum = this.a.GetEnumerator();
                IEnumerator<string> bEnum = null;
                try
                {
                    bEnum = this.b.GetEnumerator();
                    var aList = new List<string>();
                    var bList = new List<string>();
                    var aActive = true;
                    var bActive = true;

                    string value;
                    while (aActive || bActive)
                    {
                        if (bActive = bActive && bEnum.MoveNext())
                        {
                            value = bEnum.Current;

                            for (var i = 0; i < aList.Count; i++)
                            {
                                yield return aList[i] + value;
                            }

                            bList.Add(value);
                        }

                        if (aActive = aActive && aEnum.MoveNext())
                        {
                            value = aEnum.Current;

                            for (var i = 0; i < bList.Count; i++)
                            {
                                yield return value + bList[i];
                            }

                            aList.Add(value);
                        }
                    }
                }
                finally
                {
                    if (bEnum is IDisposable disposable)
                    {
                        disposable.Dispose();
                    }
                }
            }
            finally
            {
                if (aEnum is IDisposable disposable)
                {
                    disposable.Dispose();
                }
            }
        }

        public override int GetHashCode()
        {
            var hash = 0x51ED270B;
            hash = (hash * -0x25555529) + this.a.GetHashCode();
            hash = (hash * -0x25555529) + this.b.GetHashCode();

            return hash;
        }

        protected override IEnumerable<RegexMatch> GetMatchesImpl(string subject, int index)
        {
            foreach (var matchA in this.a.GetMatches(subject, index))
            {
                foreach (var matchB in this.b.GetMatches(subject, index + matchA.Length))
                {
                    yield return new RegexMatch(subject, index, matchA.Length + matchB.Length, new[] { matchA, matchB });
                }
            }
        }
    }
}
