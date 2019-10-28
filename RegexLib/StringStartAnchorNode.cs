// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace RegexLib
{
    using System;
    using System.Collections.Generic;

    public class StringStartAnchorNode : RegexNode
    {
        public override bool Equals(RegexNode other) => other is StringStartAnchorNode;

        public override string GenerateString(Random rand)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode() => 0;

        protected override IEnumerable<RegexMatch> GetMatchesImpl(string subject, int index)
        {
            if (index == 0)
            {
                yield return new RegexMatch(subject, index, 0);
            }
        }
    }
}
