// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

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
            this.ranges = new[] { new CharacterRange() };
        }

        public CharacterClassNode(char character)
        {
            this.ranges = new[] { new CharacterRange(character) };
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
            if (!(other is CharacterClassNode characterClassNode) ||
                this.ranges.Length != characterClassNode.ranges.Length)
            {
                return false;
            }

            for (var i = 0; i < this.ranges.Length; i++)
            {
                if (this.ranges[i] != characterClassNode.ranges[i])
                {
                    return false;
                }
            }

            return true;
        }

        public override string GenerateString(Random rand)
        {
            var characterCount = this.ranges.Sum(r => r.CharacterCount);
            var offset = rand.Next(characterCount);

            var range = 0;
            while (offset >= this.ranges[range].CharacterCount)
            {
                offset -= this.ranges[range].CharacterCount;
            }

            return new string((char)(this.ranges[range].MinChar + offset), 1);
        }

        public override int GetHashCode()
        {
            var hash = 0x51ED270B;
            for (var i = 0; i < this.ranges.Length; i++)
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

                var match = false;
                for (var i = 0; i < this.ranges.Length; i++)
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
    }
}
