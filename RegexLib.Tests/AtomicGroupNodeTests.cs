// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace RegexLib.Tests
{
    using System;
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class AtomicGroupNodeTests
    {
        [Test]
        public void ctor_WithNullWrappedNode_ThrowsArgumentNullException()
        {
            Assert.That(() => new AtomicGroupNode(null), Throws.InstanceOf<ArgumentNullException>());
        }

        [Test]
        public void Equals_WithNullReference_ReturnsFalse()
        {
            var subject = new AtomicGroupNode(new StubRegexNode());

            Assert.That(subject.Equals(null), Is.False);
        }

        [Theory]
        public void Equals_WithOtherAtomicGroup_MatchesOnlyIfWrappedNodesMatch(bool returnEquals)
        {
            var subject = new AtomicGroupNode(new StubRegexNode(returnEquals));
            var other = new AtomicGroupNode(new StubRegexNode());

            var expected = returnEquals;

            Assert.That(subject.Equals(other), Is.EqualTo(expected));
        }

        [Test]
        public void Equals_WithOtherObject_ReturnsFalse()
        {
            var subject = new AtomicGroupNode(new StubRegexNode());
            var other = new object();

            Assert.That(subject.Equals(other), Is.False);
        }

        [Test]
        public void Matches_WhenWrappedNodeYieldsMany_YieldsOnlyFirstMatch()
        {
            var matches = new[]
            {
                new RegexMatch("OK", 0, 0),
                new RegexMatch("OK", 0, 1),
                new RegexMatch("OK", 0, 2),
                new RegexMatch("OK", 1, 0),
                new RegexMatch("OK", 1, 1),
                new RegexMatch("OK", 2, 0),
            };

            var subject = new AtomicGroupNode(new StubRegexNode(matches: matches));

            var actual = subject.GetMatches("OK", 0).ToArray();
            var expected = matches.Take(1).ToArray();

            Assert.That(actual, Is.EquivalentTo(expected));
        }

        [Test]
        public void Matches_WhenWrappedNodeYieldsNone_YieldsNone()
        {
            var subject = new AtomicGroupNode(new StubRegexNode());

            var actual = subject.GetMatches("OK", 0).ToArray();

            Assert.That(actual, Is.Empty);
        }

        [Test]
        public void Matches_WhenWrappedNodeYieldsOne_YieldsThatMatch()
        {
            var matches = new[]
            {
                new RegexMatch("OK", 0, 0),
            };

            var subject = new AtomicGroupNode(new StubRegexNode(matches: matches));

            var actual = subject.GetMatches("OK", 0).ToArray();

            Assert.That(actual, Is.EquivalentTo(matches));
        }
    }
}
