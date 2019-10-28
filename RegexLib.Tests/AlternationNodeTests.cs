// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace RegexLib.Tests
{
    using System;
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class AlternationNodeTests
    {
        [Test]
        public void ctor_WithNullA_ThrowsArgumentNullException()
        {
            Assert.That(() => new AlternationNode(null, new StubRegexNode()), Throws.InstanceOf<ArgumentNullException>());
        }

        [Test]
        public void ctor_WithNullB_ThrowsArgumentNullException()
        {
            Assert.That(() => new AlternationNode(new StubRegexNode(), null), Throws.InstanceOf<ArgumentNullException>());
        }

        [Test]
        public void Equals_WithNullReference_ReturnsFalse()
        {
            var subject = new AlternationNode(
                new StubRegexNode(),
                new StubRegexNode());

            Assert.That(subject.Equals(null), Is.False);
        }

        [Theory]
        public void Equals_WithOtherAlternation_MatchesOnlyIfBothElementsMatch(bool returnEqualsA, bool returnEqualsB)
        {
            var subject = new AlternationNode(
                new StubRegexNode(returnEqualsA),
                new StubRegexNode(returnEqualsB));
            var other = new AlternationNode(
                new StubRegexNode(),
                new StubRegexNode());

            var expected = returnEqualsA && returnEqualsB;

            Assert.That(subject.Equals(other), Is.EqualTo(expected));
        }

        [Test]
        public void Equals_WithOtherObject_ReturnsFalse()
        {
            var subject = new AlternationNode(
                new StubRegexNode(),
                new StubRegexNode());
            var other = new object();

            Assert.That(subject.Equals(other), Is.False);
        }

        [Test]
        public void GetMatches_WhenNeitherMatch_YieldsNone()
        {
            var subject = new AlternationNode(
                new StubRegexNode(),
                new StubRegexNode());

            var result = subject.GetMatches("OK", 0);

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void GetMatches_WithAMatching_YieldsElementsFromA()
        {
            var aMatches = new[] { new RegexMatch("OK", 0, 1) };

            var subject = new AlternationNode(
                new StubRegexNode(matches: aMatches),
                new StubRegexNode());

            var result = subject.GetMatches("OK", 0).ToList();

            Assert.That(result, Is.EquivalentTo(aMatches));
        }

        [Test]
        public void GetMatches_WithBMatching_YieldsElementsFromB()
        {
            var bMatches = new[] { new RegexMatch("OK", 0, 1) };

            var subject = new AlternationNode(
                new StubRegexNode(),
                new StubRegexNode(matches: bMatches));

            var result = subject.GetMatches("OK", 0).ToList();

            Assert.That(result, Is.EquivalentTo(bMatches));
        }

        [Test]
        public void GetMatches_WithBothAAndBMatching_YieldsElementsFromBoth()
        {
            var aMatches = new[] { new RegexMatch("OK", 0, 1) };
            var bMatches = new[] { new RegexMatch("OK", 0, 2) };

            var subject = new AlternationNode(
                new StubRegexNode(matches: aMatches),
                new StubRegexNode(matches: bMatches));

            var result = subject.GetMatches("OK", 0).ToList();

            Assert.That(result, Is.EquivalentTo(aMatches.Concat(bMatches)));
        }
    }
}
