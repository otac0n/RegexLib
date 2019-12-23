// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace RegexLib
{
    using System;
    using System.Collections.Generic;

    public class AlternationNode : RegexNode
    {
        private readonly RegexNode a;
        private readonly RegexNode b;

        public AlternationNode(RegexNode a, RegexNode b)
        {
            this.a = a ?? throw new ArgumentNullException(nameof(a));
            this.b = b ?? throw new ArgumentNullException(nameof(b));
        }

        public override bool Equals(RegexNode other) =>
            other is AlternationNode alternation &&
            this.a == alternation.a &&
            this.b == alternation.b;

        public override string GenerateString(Random rand)
        {
            if (rand.Next(2) == 0)
            {
                return this.a.GenerateString(rand);
            }
            else
            {
                return this.b.GenerateString(rand);
            }
        }

        public override IEnumerator<string> GetEnumerator()
        {
            IEnumerator<string> bEnum = null;
            try
            {
                var bActive = true;
                bEnum = this.b.GetEnumerator();
                foreach (var a in this.a)
                {
                    yield return a;
                    if (bActive = bActive && bEnum.MoveNext())
                    {
                        yield return bEnum.Current;
                    }
                }

                if (bActive)
                {
                    while (bEnum.MoveNext())
                    {
                        yield return bEnum.Current;
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

        public override int GetHashCode()
        {
            var hash = 0x51ED270B;
            hash = (hash * -0x25555529) + this.a.GetHashCode();
            hash = (hash * -0x25555529) + this.b.GetHashCode();

            return hash;
        }

        protected override IEnumerable<RegexMatch> GetMatchesImpl(string subject, int index)
        {
            foreach (var match in this.a.GetMatches(subject, index))
            {
                yield return match;
            }

            foreach (var match in this.b.GetMatches(subject, index))
            {
                yield return match;
            }
        }
    }
}
