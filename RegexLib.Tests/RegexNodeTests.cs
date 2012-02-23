//-----------------------------------------------------------------------
// <copyright file="RegexNodeTests.cs" company="(none)">
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

namespace RegexLib.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class RegexNodeTests
    {
        [Test]
        public void OpEquality_WithBothNodesNullReference_ReturnsTrue()
        {
            var subjectA = (RegexNode)null;
            var subjectB = (RegexNode)null;

            Assert.That(subjectA == subjectB, Is.True);
        }

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

            var result = (subject == other);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Theory]
        public void OpEquality_WithNullReference_ReturnsFalse(bool returnEquals)
        {
            var subject = new StubRegexNode(returnEquals);

            var result = (subject == null);

            Assert.That(result, Is.False);
        }

        public class StubRegexNode : RegexNode
        {
            private readonly bool? returnEquals;

            public StubRegexNode(bool? returnEquals = null)
            {
                this.returnEquals = returnEquals;
            }

            public override bool Equals(RegexNode other)
            {
                return this.returnEquals.Value;
            }

            public override int GetHashCode()
            {
                return 0;
            }
        }
    }
}
