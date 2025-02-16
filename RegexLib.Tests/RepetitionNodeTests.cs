// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace RegexLib.Tests
{
    using System;
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class RepetitionNodeTests
    {
        [Test]
        public void ctor_WithMaximumLessThanMinimum_ThrowsArgumentOutOfRangeException()
        {
            Assert.That(() => new RepetitionNode(new StubRegexNode(), 1, 0, true), Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void ctor_WithNegativeMinimum_ThrowsArgumentOutOfRangeException()
        {
            Assert.That(() => new RepetitionNode(new StubRegexNode(), -1, null, true), Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void ctor_WithNullRepeatedNode_ThrowsArgumentNullException()
        {
            Assert.That(() => new RepetitionNode(null, 0, null, true), Throws.InstanceOf<ArgumentNullException>());
        }

        [Test]
        public void Equals_WithNullReference_ReturnsFalse()
        {
            var subject = new RepetitionNode(new StubRegexNode(), 0, null, true);

            Assert.That(subject.Equals(null), Is.False);
        }

        [Test]
        public void Equals_WithOtherObject_ReturnsFalse()
        {
            var subject = new RepetitionNode(new StubRegexNode(), 0, null, true);
            var other = new object();

            Assert.That(subject.Equals(other), Is.False);
        }

        [Theory]
        public void Equals_WithOtherRepetition_MatchesOnlyIfAllComponentsMatch(bool returnEquals, bool minMatch, bool maxMatch, bool eagerMatch)
        {
            var subject = new RepetitionNode(new StubRegexNode(returnEquals), 0, 1, true);
            var other = new RepetitionNode(new StubRegexNode(), minMatch ? 0 : 1, maxMatch ? 1 : (int?)null, eagerMatch);

            var expected = returnEquals && minMatch && maxMatch && eagerMatch;

            Assert.That(subject.Equals(other), Is.EqualTo(expected));
        }

        [Test]
        public void Matches_EagerWithMaximum_YieldsAtLeastTheMaximum()
        {
            var subject = new RepetitionNode(new CharacterClassNode('a'), 0, 2, true);

            var actual = subject.GetMatches("aaa", 0).ToArray();

            var matches = new[]
            {
                new RegexMatch("aaa", 0, 1),
                new RegexMatch("aaa", 1, 1),
                new RegexMatch("aaa", 2, 1),
            };

            var expected = new[]
            {
                new RegexMatch("aaa", 0, 2, matches.Take(2)),
                new RegexMatch("aaa", 0, 1, matches.Take(1)),
                new RegexMatch("aaa", 0, 0, matches.Take(0)),
            };

            Assert.That(actual, Is.EquivalentTo(expected));
        }

        [Test]
        public void Matches_EagerWithMinimum_YieldsAtLeastTheMinimum()
        {
            var subject = new RepetitionNode(new CharacterClassNode('a'), 2, null, true);

            var actual = subject.GetMatches("aaa", 0).ToArray();

            var matches = new[]
            {
                new RegexMatch("aaa", 0, 1),
                new RegexMatch("aaa", 1, 1),
                new RegexMatch("aaa", 2, 1),
            };

            var expected = new[]
            {
                new RegexMatch("aaa", 0, 3, matches.Take(3)),
                new RegexMatch("aaa", 0, 2, matches.Take(2)),
            };

            Assert.That(actual, Is.EquivalentTo(expected));
        }

        [Test]
        public void Matches_EagerWithMinimumAndMaximum_YieldsBetweenTheMinimumAndMaximum()
        {
            var subject = new RepetitionNode(new CharacterClassNode('a'), 1, 2, true);

            var actual = subject.GetMatches("aaa", 0).ToArray();

            var matches = new[]
            {
                new RegexMatch("aaa", 0, 1),
                new RegexMatch("aaa", 1, 1),
                new RegexMatch("aaa", 2, 1),
            };

            var expected = new[]
            {
                new RegexMatch("aaa", 0, 2, matches.Take(2)),
                new RegexMatch("aaa", 0, 1, matches.Take(1)),
            };

            Assert.That(actual, Is.EquivalentTo(expected));
        }

        [Test]
        public void Matches_EagerWithMinimumMoreThanAvailable_YieldsNone()
        {
            var subject = new RepetitionNode(new CharacterClassNode('a'), 4, null, true);

            var actual = subject.GetMatches("aaa", 0).ToArray();

            Assert.That(actual, Is.Empty);
        }

        [Test]
        public void Matches_EagerZeroWidthMatchWithZeroMinimum_YieldsOneMatch()
        {
            var matches = new[]
            {
                new RegexMatch("aaa", 0, 0),
            };

            var subject = new RepetitionNode(new StubRegexNode(matches: matches), 0, null, true);

            var actual = subject.GetMatches("aaa", 0).ToArray();

            var expected = new[]
            {
                new RegexMatch("aaa", 0, 0, matches),
                new RegexMatch("aaa", 0, 0),
            };

            Assert.That(actual, Is.EquivalentTo(expected));
        }

        [Test]
        public void Matches_LazyWithMaximum_YieldsAtLeastTheMaximum()
        {
            var subject = new RepetitionNode(new CharacterClassNode('a'), 0, 2, false);

            var actual = subject.GetMatches("aaa", 0).ToArray();

            var matches = new[]
            {
                new RegexMatch("aaa", 0, 1),
                new RegexMatch("aaa", 1, 1),
                new RegexMatch("aaa", 2, 1),
            };

            var expected = new[]
            {
                new RegexMatch("aaa", 0, 0, matches.Take(0)),
                new RegexMatch("aaa", 0, 1, matches.Take(1)),
                new RegexMatch("aaa", 0, 2, matches.Take(2)),
            };

            Assert.That(actual, Is.EquivalentTo(expected));
        }

        [Test]
        public void Matches_LazyWithMinimum_YieldsAtLeastTheMinimum()
        {
            var subject = new RepetitionNode(new CharacterClassNode('a'), 2, null, false);

            var actual = subject.GetMatches("aaa", 0).ToArray();

            var matches = new[]
            {
                new RegexMatch("aaa", 0, 1),
                new RegexMatch("aaa", 1, 1),
                new RegexMatch("aaa", 2, 1),
            };

            var expected = new[]
            {
                new RegexMatch("aaa", 0, 2, matches.Take(2)),
                new RegexMatch("aaa", 0, 3, matches.Take(3)),
            };

            Assert.That(actual, Is.EquivalentTo(expected));
        }

        [Test]
        public void Matches_LazyWithMinimumAndMaximum_YieldsBetweenTheMinimumAndMaximum()
        {
            var subject = new RepetitionNode(new CharacterClassNode('a'), 1, 2, false);

            var actual = subject.GetMatches("aaa", 0).ToArray();

            var matches = new[]
            {
                new RegexMatch("aaa", 0, 1),
                new RegexMatch("aaa", 1, 1),
                new RegexMatch("aaa", 2, 1),
            };

            var expected = new[]
            {
                new RegexMatch("aaa", 0, 1, matches.Take(1)),
                new RegexMatch("aaa", 0, 2, matches.Take(2)),
            };

            Assert.That(actual, Is.EquivalentTo(expected));
        }

        [Test]
        public void Matches_LazyWithMinimumMoreThanAvailable_YieldsNone()
        {
            var subject = new RepetitionNode(new CharacterClassNode('a'), 4, null, false);

            var actual = subject.GetMatches("aaa", 0).ToArray();

            Assert.That(actual, Is.Empty);
        }

        [Test]
        public void Matches_LazyZeroWidthMatchWithZeroMinimum_YieldsOneMatch()
        {
            var matches = new[]
            {
                new RegexMatch("aaa", 0, 0),
            };

            var subject = new RepetitionNode(new StubRegexNode(matches: matches), 0, null, false);

            var actual = subject.GetMatches("aaa", 0).ToArray();

            var expected = new[]
            {
                new RegexMatch("aaa", 0, 0),
                new RegexMatch("aaa", 0, 0, matches),
            };

            Assert.That(actual, Is.EquivalentTo(expected));
        }

        [Test]
        public void Matches_WithEagerMatching_BacktracksToFewerMatches()
        {
            var subject = new RepetitionNode(new CharacterClassNode('a'), 0, null, true);

            var actual = subject.GetMatches("aaa", 0).ToArray();

            var matches = new[]
            {
                new RegexMatch("aaa", 0, 1),
                new RegexMatch("aaa", 1, 1),
                new RegexMatch("aaa", 2, 1),
            };

            var expected = new[]
            {
                new RegexMatch("aaa", 0, 3, matches.Take(3)),
                new RegexMatch("aaa", 0, 2, matches.Take(2)),
                new RegexMatch("aaa", 0, 1, matches.Take(1)),
                new RegexMatch("aaa", 0, 0, matches.Take(0)),
            };

            Assert.That(actual, Is.EquivalentTo(expected));
        }

        [Test]
        public void Matches_WithLazyMatching_BacktracksToMoreMatches()
        {
            var subject = new RepetitionNode(new CharacterClassNode('a'), 0, null, false);

            var actual = subject.GetMatches("aaa", 0).ToArray();

            var matches = new[]
            {
                new RegexMatch("aaa", 0, 1),
                new RegexMatch("aaa", 1, 1),
                new RegexMatch("aaa", 2, 1),
            };

            var expected = new[]
            {
                new RegexMatch("aaa", 0, 0, matches.Take(0)),
                new RegexMatch("aaa", 0, 1, matches.Take(1)),
                new RegexMatch("aaa", 0, 2, matches.Take(2)),
                new RegexMatch("aaa", 0, 3, matches.Take(3)),
            };

            Assert.That(actual, Is.EquivalentTo(expected));
        }

        [Theory]
        public void Matches_ZeroWidthMatchWithMinimumAndMaximum_YieldsTheMinimum(bool eager)
        {
            var matches = new[]
            {
                new RegexMatch("aaa", 0, 0),
            };

            var subject = new RepetitionNode(new StubRegexNode(matches: matches), 2, 3, eager);

            var actual = subject.GetMatches("aaa", 0).ToArray();

            var expected = new[]
            {
                new RegexMatch("aaa", 0, 0, matches.Concat(matches)),
            };

            Assert.That(actual, Is.EquivalentTo(expected));
        }

        [Theory]
        public void Matches_ZeroWidthMatchWithMinimumAndNoMaximum_YieldsTheMinimum(bool eager)
        {
            var matches = new[]
            {
                new RegexMatch("aaa", 0, 0),
            };

            var subject = new RepetitionNode(new StubRegexNode(matches: matches), 2, null, eager);

            var actual = subject.GetMatches("aaa", 0).ToArray();

            var expected = new[]
            {
                new RegexMatch("aaa", 0, 0, matches.Concat(matches)),
            };

            Assert.That(actual, Is.EquivalentTo(expected));
        }
    }
}
