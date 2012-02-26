//-----------------------------------------------------------------------
// <copyright file="RegexMatch.cs" company="(none)">
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
    using System.Linq;

    public class RegexMatch : IEquatable<RegexMatch>
    {
        private readonly string subject;
        private readonly int startIndex;
        private readonly int length;
        private readonly string value;
        private readonly RegexMatch[] subMatches;

        public RegexMatch(string subject, int startIndex, int length)
            : this(subject, startIndex, length, null)
        {
        }

        public RegexMatch(string subject, int startIndex, int length, IEnumerable<RegexMatch> subMatches)
        {
            if (subject == null)
            {
                throw new ArgumentNullException("subject");
            }

            if (startIndex < 0 || startIndex > subject.Length)
            {
                throw new ArgumentOutOfRangeException("startIndex");
            }

            if (length < 0 || (startIndex + length) > subject.Length)
            {
                throw new ArgumentOutOfRangeException("length");
            }

            var matchesCopy = subMatches == null ? new RegexMatch[0] : subMatches.ToArray();
            if (matchesCopy.Any(m => m == null))
            {
                throw new ArgumentOutOfRangeException("matches");
            }

            this.subject = subject;
            this.startIndex = startIndex;
            this.length = length;
            this.value = subject.Substring(startIndex, length);
            this.subMatches = matchesCopy;
        }

        public string Subject
        {
            get { return this.subject; }
        }

        public int StartIndex
        {
            get { return this.startIndex; }
        }

        public int Length
        {
            get { return this.length; }
        }

        public string Value
        {
            get { return this.value; }
        }

        public static bool operator ==(RegexMatch nodeA, RegexMatch nodeB)
        {
            return object.Equals(nodeA, nodeB);
        }

        public static bool operator !=(RegexMatch nodeA, RegexMatch nodeB)
        {
            return !object.Equals(nodeA, nodeB);
        }

        public bool Equals(RegexMatch other)
        {
            bool possiblyEqual = !object.ReferenceEquals(other, null) &&
                other.subject == this.subject &&
                other.startIndex == this.startIndex &&
                other.length == this.length &&
                other.subMatches.Length == this.subMatches.Length;

            if (!possiblyEqual)
            {
                return false;
            }

            for (int i = 0; i < this.subMatches.Length; i++)
            {
                if (this.subMatches[i] != other.subMatches[i])
                {
                    return false;
                }
            }

            return true;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as RegexMatch);
        }

        public override int GetHashCode()
        {
            int hash = 0x51ED270B;
            hash = (hash * -0x25555529) + this.subject.GetHashCode();
            hash = (hash * -0x25555529) + this.value.GetHashCode();
            hash = (hash * -0x25555529) + this.startIndex.GetHashCode();

            return hash;
        }
    }
}
