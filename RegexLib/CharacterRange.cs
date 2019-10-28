// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace RegexLib
{
    using System;

    public class CharacterRange
    {
        public CharacterRange()
            : this(char.MinValue, char.MaxValue)
        {
        }

        public CharacterRange(char character)
            : this(character, character)
        {
        }

        public CharacterRange(char minChar, char maxChar)
        {
            if (maxChar < minChar)
            {
                throw new ArgumentOutOfRangeException(nameof(maxChar));
            }

            this.MinChar = minChar;
            this.MaxChar = maxChar;
        }

        public int CharacterCount => this.MaxChar - this.MinChar + 1;

        public char MaxChar { get; }

        public char MinChar { get; }

        public static bool operator !=(CharacterRange rangeA, CharacterRange rangeB)
        {
            return !object.Equals(rangeA, rangeB);
        }

        public static bool operator ==(CharacterRange rangeA, CharacterRange rangeB)
        {
            return object.Equals(rangeA, rangeB);
        }

        public override bool Equals(object obj) =>
            obj is CharacterRange range &&
            range.MinChar == this.MinChar &&
            range.MaxChar == this.MaxChar;

        public override int GetHashCode()
        {
            var hash = 0x51ED270B;
            hash = (hash * -0x25555529) + this.MinChar.GetHashCode();
            hash = (hash * -0x25555529) + this.MaxChar.GetHashCode();

            return hash;
        }

        public bool Matches(char c) =>
            this.MinChar <= c &&
            this.MaxChar >= c;
    }
}
