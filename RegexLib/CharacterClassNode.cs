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
    using System.Linq;

    public class CharacterClassNode : RegexNode
    {
        private readonly CharacterRange[] ranges;

        public CharacterClassNode()
        {
            this.ranges = new[] { new CharacterRange(char.MinValue, char.MaxValue) };
        }

        public CharacterClassNode(char character)
        {
            this.ranges = new[] { new CharacterRange(character, character) };
        }

        public CharacterClassNode(char minChar, char maxChar)
        {
            this.ranges = new[] { new CharacterRange(minChar, maxChar) };
        }

        public CharacterClassNode(params CharacterRange[] ranges)
            : this((IEnumerable<CharacterRange>)ranges)
        {
        }

        public CharacterClassNode(IEnumerable<CharacterRange> ranges)
        {
            var results = new List<CharacterRange>();
            foreach (var range in ranges.OrderBy(r => r.MinChar))
            {
                if (results.Count == 0 ||
                    results[results.Count - 1].MaxChar + 1 < range.MinChar)
                {
                    results.Add(range);
                }
                else
                {
                    var last = results[results.Count - 1];
                    results.RemoveAt(results.Count - 1);
                    results.Add(new CharacterRange(last.MinChar, last.MaxChar > range.MaxChar ? last.MaxChar : range.MaxChar));
                }
            }

            this.ranges = results.ToArray();
        }

        public override bool Equals(RegexNode other)
        {
            var characterClassNode = other as CharacterClassNode;
            if (object.ReferenceEquals(characterClassNode, null) ||
                this.ranges.Length != characterClassNode.ranges.Length)
            {
                return false;
            }

            for (int i = 0; i < this.ranges.Length; i++)
            {
                if (this.ranges[i] != characterClassNode.ranges[i])
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            int hash = 0x51ED270B;
            for (int i = 0; i < this.ranges.Length; i++)
            {
                hash = (hash * -0x25555529) + this.ranges[i].GetHashCode();
            }

            return hash;
        }

        protected override IEnumerable<RegexMatch> GetMatchesImpl(string subject, int index)
        {
            if (index < subject.Length)
            {
                var c = subject[index];

                bool match = false;
                for (int i = 0; i < this.ranges.Length; i++)
                {
                    if (this.ranges[i].Matches(c))
                    {
                        match = true;
                        break;
                    }
                }

                if (match)
                {
                    yield return new RegexMatch(subject, index, 1);
                }
            }
        }

        public override string GenerateString(Random rand)
        {
            var characterCount = this.ranges.Sum(r => r.CharacterCount);
            var offset = rand.Next(characterCount);

            int range = 0;
            while (offset >= this.ranges[range].CharacterCount)
            {
                offset -= this.ranges[range].CharacterCount;
            }

            return ((char)(this.ranges[range].MinChar + offset)).ToString();
        }

        public class CharacterRange
        {
            private readonly char minChar;
            private readonly char maxChar;

            public CharacterRange(char minChar, char maxChar)
            {
                if (maxChar < minChar)
                {
                    throw new ArgumentOutOfRangeException("maxChar");
                }

                this.minChar = minChar;
                this.maxChar = maxChar;
            }

            public char MinChar
            {
                get { return this.minChar; }
            }

            public char MaxChar
            {
                get { return this.maxChar; }
            }

            public int CharacterCount
            {
                get { return this.maxChar - this.minChar + 1; }
            }

            public bool Matches(char c)
            {
                return this.minChar <= c &&
                       this.maxChar >= c;
            }

            public static bool operator ==(CharacterRange rangeA, CharacterRange rangeB)
            {
                return object.Equals(rangeA, rangeB);
            }

            public static bool operator !=(CharacterRange rangeA, CharacterRange rangeB)
            {
                return !object.Equals(rangeA, rangeB);
            }

            public override bool Equals(object obj)
            {
                var range = obj as CharacterRange;
                return !object.ReferenceEquals(range, null) &&
                       range.minChar == this.minChar &&
                       range.maxChar == this.maxChar;
            }

            public override int GetHashCode()
            {
                int hash = 0x51ED270B;
                hash = (hash * -0x25555529) + this.minChar.GetHashCode();
                hash = (hash * -0x25555529) + this.maxChar.GetHashCode();

                return hash;
            }
        }
    }
}
