﻿//-----------------------------------------------------------------------
// <copyright file="ConcatenationNode.cs" company="(none)">
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

    public class ConcatenationNode : RegexNode
    {
        private readonly RegexNode a;
        private readonly RegexNode b;

        public ConcatenationNode(RegexNode a, RegexNode b)
        {
            if (a == null)
            {
                throw new ArgumentNullException("a");
            }

            if (b == null)
            {
                throw new ArgumentNullException("b");
            }

            this.a = a;
            this.b = b;
        }

        public override bool Equals(RegexNode other)
        {
            var alternation = other as ConcatenationNode;

            return !object.ReferenceEquals(alternation, null) &&
                this.a == alternation.a &&
                this.b == alternation.b;
        }

        public override int GetHashCode()
        {
            int hash = 0x51ED270B;
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

        public override string GenerateString(Random rand)
        {
            return this.a.GenerateString(rand) + this.b.GenerateString(rand);
        }
    }
}
