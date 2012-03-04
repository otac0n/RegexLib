//-----------------------------------------------------------------------
// <copyright file="CharacterClassNode.cs" company="(none)">
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
    using System.Globalization;

    public class CharacterClassNode : RegexNode
    {
        private readonly char minChar;
        private readonly char maxChar;

        public CharacterClassNode()
        {
            this.minChar = char.MinValue;
            this.maxChar = char.MaxValue;
        }

        public CharacterClassNode(char character)
        {
            this.minChar = character;
            this.maxChar = character;
        }

        public CharacterClassNode(char minChar, char maxChar)
        {
            if (maxChar < minChar)
            {
                throw new ArgumentOutOfRangeException("maxChar");
            }

            this.minChar = minChar;
            this.maxChar = maxChar;
        }

        public override bool Equals(RegexNode other)
        {
            var characterClassNode = other as CharacterClassNode;
            return !object.ReferenceEquals(characterClassNode, null) &&
                this.minChar == characterClassNode.minChar &&
                this.maxChar == characterClassNode.maxChar;
        }

        public override int GetHashCode()
        {
            int hash = 0x51ED270B;
            hash = (hash * -0x25555529) + this.minChar.GetHashCode();
            hash = (hash * -0x25555529) + this.maxChar.GetHashCode();

            return hash;
        }

        protected override IEnumerable<RegexMatch> GetMatchesImpl(string subject, int index)
        {
            if (index < subject.Length &&
                this.minChar <= subject[index] &&
                this.maxChar >= subject[index])
            {
                yield return new RegexMatch(subject, index, 1);
            }
        }

        public override string GenerateString(Random rand)
        {
            var range = this.maxChar - this.minChar;
            var offset = rand.Next(range + 1);
            return ((char)(this.minChar + offset)).ToString();
        }
    }
}
