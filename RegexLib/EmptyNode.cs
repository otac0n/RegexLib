// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace RegexLib
{
    using System;
    using System.Collections.Generic;

    public class EmptyNode : RegexNode
    {
        public override bool Equals(RegexNode other) => other is EmptyNode;

        public override string GenerateString(Random rand) => string.Empty;

        public override IEnumerator<string> GetEnumerator()
        {
            yield return string.Empty;
        }

        public override int GetHashCode() => 0;

        protected override IEnumerable<RegexMatch> GetMatchesImpl(string subject, int index)
        {
            yield return new RegexMatch(subject, index, 0);
        }
    }
}
