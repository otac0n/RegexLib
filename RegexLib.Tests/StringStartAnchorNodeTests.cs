// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace RegexLib.Tests
{
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class StringStartAnchorNodeTests
    {
        [Test]
        public void Equals_WithNullReference_ReturnsFalse()
        {
            var subject = new StringStartAnchorNode();

            Assert.That(subject.Equals(null), Is.False);
        }

        [Test]
        public void Equals_WithOtherObject_ReturnsFalse()
        {
            var subject = new StringStartAnchorNode();
            var other = new object();

            Assert.That(subject.Equals(other), Is.False);
        }

        [Test]
        public void Equals_WithOtherStringStartAnchorNode_ReturnsTrue()
        {
            var subject = new StringStartAnchorNode();
            var other = new StringStartAnchorNode();

            Assert.That(subject.Equals(other), Is.True);
        }

        [Test]
        public void GetMatches_AtTheBeginningOfTheString_YieldSingleEmptyResult()
        {
            var subject = new StringStartAnchorNode();

            var result = subject.GetMatches("OK", 0).Single();
            var expected = new RegexMatch("OK", 0, 0);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetMatches_AtTheEndOfTheString_YieldsNone()
        {
            var subject = new StringStartAnchorNode();

            var result = subject.GetMatches("OK", 2);

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void GetMatches_InTheMiddleOfTheString_YieldsNone()
        {
            var subject = new StringStartAnchorNode();

            var result = subject.GetMatches("OK", 1);

            Assert.That(result, Is.Empty);
        }
    }
}
