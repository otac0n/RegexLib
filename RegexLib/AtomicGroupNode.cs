// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace RegexLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AtomicGroupNode : RegexNode
    {
        private readonly RegexNode regexNode;

        public AtomicGroupNode(RegexNode regexNode)
        {
            this.regexNode = regexNode;

            if (regexNode == null)
            {
                throw new ArgumentNullException(nameof(regexNode));
            }
        }

        public override bool Equals(RegexNode other) =>
            other is AtomicGroupNode atomicGroup &&
            this.regexNode == atomicGroup.regexNode;

        public override string GenerateString(Random rand) => this.regexNode.GenerateString(rand);

        public override IEnumerator<string> GetEnumerator() => throw new NotImplementedException();

        public override int GetHashCode()
        {
            var hash = 0x51ED270B;
            hash = (hash * -0x25555529) + this.regexNode.GetHashCode();

            return hash;
        }

        protected override IEnumerable<RegexMatch> GetMatchesImpl(string subject, int index)
        {
            var match = this.regexNode.GetMatches(subject, index).FirstOrDefault();

            if (match != null)
            {
                yield return match;
            }
        }
    }
}
