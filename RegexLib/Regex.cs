//-----------------------------------------------------------------------
// <copyright file="Regex.cs" company="(none)">
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

    public class Regex
    {
        private readonly RegexNode rootNode;

        public Regex(RegexNode rootNode)
        {
            if (rootNode == null)
            {
                throw new ArgumentNullException("rootNode");
            }

            this.rootNode = rootNode;
        }

        private static void ValidateParameters(string subject, int startIndex)
        {
            if (subject == null)
            {
                throw new ArgumentNullException("subject");
            }

            if (startIndex < 0 ||
                startIndex > subject.Length)
            {
                throw new ArgumentOutOfRangeException("startIndex");
            }
        }

        public RegexMatch MatchAt(string subject, int index)
        {
            ValidateParameters(subject, index);

            return this.rootNode.GetMatches(subject, index).FirstOrDefault();
        }

        public IList<RegexMatch> MatchesAt(string subject, int index)
        {
            ValidateParameters(subject, index);

            return this.rootNode.GetMatches(subject, index).ToList();
        }

        public bool IsMatchAt(string subject, int index)
        {
            ValidateParameters(subject, index);

            return this.rootNode.GetMatches(subject, index).Any();
        }

        public RegexMatch Match(string subject, int startIndex)
        {
            ValidateParameters(subject, startIndex);

            var result = (RegexMatch)null;

            for (int i = startIndex; i < subject.Length && result == null; i++)
            {
                result = this.rootNode.GetMatches(subject, i).FirstOrDefault();
            }

            return result;
        }

        public RegexMatch Match(string subject)
        {
            return this.Match(subject, 0);
        }

        public bool IsMatch(string subject, int startIndex)
        {
            ValidateParameters(subject, startIndex);

            for (int i = startIndex; i < subject.Length; i++)
            {
                if (this.rootNode.GetMatches(subject, i).Any())
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsMatch(string subject)
        {
            return this.IsMatch(subject, 0);
        }

        public IList<RegexMatch> Matches(string subject, int startIndex)
        {
            ValidateParameters(subject, startIndex);

            var matches = new List<RegexMatch>();

            for (int i = startIndex; i < subject.Length; i++)
            {
                foreach (var result in this.rootNode.GetMatches(subject, startIndex))
                {
                    matches.Add(result);

                    if (result.Length > 0)
                    {
                        i += result.Length - 1;
                    }
                }
            }

            return matches;
        }

        public IList<RegexMatch> Matches(string subject)
        {
            return this.Matches(subject, 0);
        }
    }
}
