//-----------------------------------------------------------------------
// <copyright file="CharacterNode.cs" company="(none)">
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
    using System.Collections.Generic;

    public class CharacterNode : RegexNode
    {
        private readonly CharacterMatcher matcher;

        public CharacterNode(char character)
        {
            this.matcher = new SingleCharacterMatcher(character);
        }

        public override bool Equals(RegexNode other)
        {
            return (other is CharacterNode) &&
                ((CharacterNode)other).matcher.Equals(this.matcher);
        }

        public override int GetHashCode()
        {
            return this.matcher.GetHashCode();
        }

        protected override IEnumerable<RegexMatch> GetMatchesImpl(string subject, int index)
        {
            if (index < subject.Length &&
                this.matcher.Matches(subject[index]))
            {
                yield return new RegexMatch(subject, index, 1);
            }
        }

        private abstract class CharacterMatcher
        {
            public abstract override bool Equals(object obj);

            public abstract override int GetHashCode();

            public abstract bool Matches(char character);
        }

        private class SingleCharacterMatcher : CharacterMatcher
        {
            private readonly char character;

            public SingleCharacterMatcher(char character)
            {
                this.character = character;
            }

            public override bool Equals(object obj)
            {
                var single = obj as SingleCharacterMatcher;
                return single != null &&
                       single.character == this.character;
            }

            public override int GetHashCode()
            {
                return this.character.GetHashCode();
            }

            public override bool Matches(char character)
            {
                return this.character == character;
            }
        }
    }
}
