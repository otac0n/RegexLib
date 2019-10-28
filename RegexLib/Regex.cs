// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

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
            this.rootNode = rootNode ?? throw new ArgumentNullException(nameof(rootNode));
        }

        public bool IsMatch(string subject, int startIndex)
        {
            ValidateParameters(subject, startIndex);

            for (var i = startIndex; i < subject.Length; i++)
            {
                if (this.rootNode.GetMatches(subject, i).Any())
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsMatch(string subject) => this.IsMatch(subject, 0);

        public bool IsMatchAt(string subject, int index)
        {
            ValidateParameters(subject, index);

            return this.rootNode.GetMatches(subject, index).Any();
        }

        public RegexMatch Match(string subject, int startIndex)
        {
            ValidateParameters(subject, startIndex);

            var result = (RegexMatch)null;

            for (var i = startIndex; i < subject.Length && result == null; i++)
            {
                result = this.rootNode.GetMatches(subject, i).FirstOrDefault();
            }

            return result;
        }

        public RegexMatch Match(string subject) => this.Match(subject, 0);

        public RegexMatch MatchAt(string subject, int index)
        {
            ValidateParameters(subject, index);

            return this.rootNode.GetMatches(subject, index).FirstOrDefault();
        }

        public IList<RegexMatch> Matches(string subject, int startIndex)
        {
            ValidateParameters(subject, startIndex);

            var matches = new List<RegexMatch>();

            for (var i = startIndex; i < subject.Length; i++)
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

        public IList<RegexMatch> Matches(string subject) => this.Matches(subject, 0);

        public IList<RegexMatch> MatchesAt(string subject, int index)
        {
            ValidateParameters(subject, index);

            return this.rootNode.GetMatches(subject, index).ToList();
        }

        private static void ValidateParameters(string subject, int startIndex)
        {
            if (subject == null)
            {
                throw new ArgumentNullException(nameof(subject));
            }

            if (startIndex < 0 ||
                startIndex > subject.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }
        }
    }
}
