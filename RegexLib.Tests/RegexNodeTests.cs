// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace RegexLib.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class RegexNodeTests
    {
        [Theory]
        public void Equals_WithAnyOtherNode_ReturnsValueOfIEqualityEquals(bool expected)
        {
            var subject = new StubRegexNode(expected);
            var other = new StubRegexNode();

            var result = ((object)subject).Equals(other);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Theory]
        public void Equals_WithNullReference_ReturnsValueOfIEqualityEquals(bool expected)
        {
            var subject = new StubRegexNode(expected);

            var result = ((object)subject).Equals(null);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetMatches_WithAnIndexPassedTheEndOfTheString_ThrowsArgumentOutOfRangeException()
        {
            var subject = new StubRegexNode();

            Assert.That(() => subject.GetMatches("OK", 3), Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void GetMatches_WithAnNegativeIndex_ThrowsArgumentOutOfRangeException()
        {
            var subject = new StubRegexNode();

            Assert.That(() => subject.GetMatches("OK", -1), Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void GetMatches_WithANullString_ThrowsArgumentNullException()
        {
            var subject = new StubRegexNode();

            Assert.That(() => subject.GetMatches(null, 0), Throws.InstanceOf<ArgumentNullException>());
        }

        [Test]
        public void GetMatches_WithAValidStringAndIndex_ReturnsTheEnumerable()
        {
            var subject = new StubRegexNode();

            var result = subject.GetMatches("OK", 1);

            Assert.That(result, Is.Not.Null);
        }

        [Theory]
        public void ObjectEquals_WithAnyOtherNode_ReturnsValueOfIEqualityEquals(bool expected)
        {
            var subject = new StubRegexNode(expected);
            var other = new StubRegexNode();

            var result = object.Equals(subject, other);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Theory]
        public void ObjectEquals_WithNullReference_ReturnsFalse(bool returnEquals)
        {
            var subject = new StubRegexNode(returnEquals);

            var result = object.Equals(subject, null);

            Assert.That(result, Is.False);
        }

        [Theory]
        public void OpEquality_WithAnyOtherNode_ReturnsValueOfIEqualityEquals(bool expected)
        {
            var subject = new StubRegexNode(expected);
            var other = new StubRegexNode();

            var result = subject == other;

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void OpEquality_WithBothNodesNullReference_ReturnsTrue()
        {
            var subjectA = (RegexNode)null;
            var subjectB = (RegexNode)null;

            Assert.That(subjectA == subjectB, Is.True);
        }

        [Theory]
        public void OpEquality_WithNullReference_ReturnsFalse(bool returnEquals)
        {
            var subject = new StubRegexNode(returnEquals);

            var result = subject == null;

            Assert.That(result, Is.False);
        }
    }
}
