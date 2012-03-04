//-----------------------------------------------------------------------
// <copyright file="AtomicGroupNode.cs" company="(none)">
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
// <author>Katie Gietzen</author>
// <author>John Gietzen</author>
//-----------------------------------------------------------------------

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
                throw new ArgumentNullException("regexNode");
            }
        }

        public override bool Equals(RegexNode other)
        {
            var atomicGroup = other as AtomicGroupNode;
            return !object.ReferenceEquals(atomicGroup, null) &&
                this.regexNode == atomicGroup.regexNode;
        }

        public override int GetHashCode()
        {
            int hash = 0x51ED270B;
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

        public override string GenerateString(Random rand)
        {
            return this.regexNode.GenerateString(rand);
        }
    }
}
