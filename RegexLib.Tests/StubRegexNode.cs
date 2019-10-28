// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace RegexLib.Tests
{
    using System;
    using System.Collections.Generic;

    public class StubRegexNode : RegexNode
    {
        private readonly RegexMatch[] matches;
        private readonly bool? returnEquals;

        public StubRegexNode(bool? returnEquals = null, RegexMatch[] matches = null)
        {
            this.returnEquals = returnEquals;
            this.matches = matches ?? new RegexMatch[0];
        }

        public override bool Equals(RegexNode other)
        {
            return this.returnEquals.Value;
        }

        public override string GenerateString(Random rand)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return 0;
        }

        protected override IEnumerable<RegexMatch> GetMatchesImpl(string subject, int index)
        {
            return this.matches;
        }
    }
}
