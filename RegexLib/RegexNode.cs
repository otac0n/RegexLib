// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace RegexLib
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public abstract class RegexNode : IEquatable<RegexNode>, IEnumerable<string>
    {
        public static bool operator !=(RegexNode nodeA, RegexNode nodeB)
        {
            return !object.Equals(nodeA, nodeB);
        }

        public static bool operator ==(RegexNode nodeA, RegexNode nodeB)
        {
            return object.Equals(nodeA, nodeB);
        }

        public abstract bool Equals(RegexNode other);

        public override bool Equals(object obj) => this.Equals(obj as RegexNode);

        public abstract string GenerateString(Random rand);

        public abstract IEnumerator<string> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        public abstract override int GetHashCode();

        public IEnumerable<RegexMatch> GetMatches(string subject, int index)
        {
            if (subject == null)
            {
                throw new ArgumentNullException(nameof(subject));
            }

            if (index < 0 ||
                index > subject.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            return this.GetMatchesImpl(subject, index);
        }

        protected abstract IEnumerable<RegexMatch> GetMatchesImpl(string subject, int index);
    }
}
