// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace RegexLib
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class RegexMatch : IEquatable<RegexMatch>
    {
        private readonly RegexMatch[] subMatches;

        public RegexMatch(string subject, int startIndex, int length)
            : this(subject, startIndex, length, null)
        {
        }

        public RegexMatch(string subject, int startIndex, int length, IEnumerable<RegexMatch> subMatches)
        {
            if (subject == null)
            {
                throw new ArgumentNullException(nameof(subject));
            }

            if (startIndex < 0 || startIndex > subject.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (length < 0 || (startIndex + length) > subject.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }

            var matchesCopy = subMatches == null ? new RegexMatch[0] : subMatches.ToArray();
            var requiredStartIndex = startIndex;
            for (var i = 0; i < matchesCopy.Length; i++)
            {
                var subMatch = matchesCopy[i];
                if (subMatch == null ||
                    subMatch.StartIndex != requiredStartIndex)
                {
                    throw new ArgumentOutOfRangeException(nameof(subMatches));
                }

                requiredStartIndex = subMatch.StartIndex + subMatch.Length;
            }

            if (matchesCopy.Length > 0 && requiredStartIndex != startIndex + length)
            {
                throw new ArgumentOutOfRangeException(nameof(subMatches));
            }

            this.Subject = subject;
            this.StartIndex = startIndex;
            this.Length = length;
            this.Value = subject.Substring(startIndex, length);
            this.subMatches = matchesCopy;
        }

        public int Length { get; }

        public int StartIndex { get; }

        public string Subject { get; }

        public string Value { get; }

        public static bool operator !=(RegexMatch nodeA, RegexMatch nodeB)
        {
            return !object.Equals(nodeA, nodeB);
        }

        public static bool operator ==(RegexMatch nodeA, RegexMatch nodeB)
        {
            return object.Equals(nodeA, nodeB);
        }

        public bool Equals(RegexMatch other)
        {
            var possiblyEqual = other is object &&
                other.Subject == this.Subject &&
                other.StartIndex == this.StartIndex &&
                other.Length == this.Length &&
                other.subMatches.Length == this.subMatches.Length;

            if (!possiblyEqual)
            {
                return false;
            }

            for (var i = 0; i < this.subMatches.Length; i++)
            {
                if (this.subMatches[i] != other.subMatches[i])
                {
                    return false;
                }
            }

            return true;
        }

        public override bool Equals(object obj) => this.Equals(obj as RegexMatch);

        public override int GetHashCode()
        {
            var hash = 0x51ED270B;
            hash = (hash * -0x25555529) + this.Subject.GetHashCode();
            hash = (hash * -0x25555529) + this.Value.GetHashCode();
            hash = (hash * -0x25555529) + this.StartIndex.GetHashCode();

            return hash;
        }

        public override string ToString() => string.Format(CultureInfo.CurrentCulture, "\"{0}\"({1},{2})", this.Value, this.StartIndex, this.Length);
    }
}
