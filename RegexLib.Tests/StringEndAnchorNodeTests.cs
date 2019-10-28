// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace RegexLib.Tests
{
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class StringEndAnchorNodeTests
    {
        [Test]
        public void Equals_WithNullReference_ReturnsFalse()
        {
            var subject = new StringEndAnchorNode();

            Assert.That(subject.Equals(null), Is.False);
        }

        [Test]
        public void Equals_WithOtherObject_ReturnsFalse()
        {
            var subject = new StringEndAnchorNode();
            var other = new object();

            Assert.That(subject.Equals(other), Is.False);
        }

        [Test]
        public void Equals_WithOtherStringEndAnchorNode_ReturnsTrue()
        {
            var subject = new StringEndAnchorNode();
            var other = new StringEndAnchorNode();

            Assert.That(subject.Equals(other), Is.True);
        }

        [Test]
        public void GetMatches_AtTheBeginningOfTheString_YieldsNone()
        {
            var subject = new StringEndAnchorNode();

            var result = subject.GetMatches("OK", 0);

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void GetMatches_AtTheEndOfTheString_YieldSingleEmptyResult()
        {
            var subject = new StringEndAnchorNode();

            var result = subject.GetMatches("OK", 2).Single();
            var expected = new RegexMatch("OK", 2, 0);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetMatches_InTheMiddleOfTheString_YieldsNone()
        {
            var subject = new StringEndAnchorNode();

            var result = subject.GetMatches("OK", 1);

            Assert.That(result, Is.Empty);
        }
    }
}
