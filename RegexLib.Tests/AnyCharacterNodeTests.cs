//-----------------------------------------------------------------------
// <copyright file="AnyCharacterNodeTests.cs" company="(none)">
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
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class AnyCharacterNodeTests
    {
        [Test]
        public void Equals_WithNullReference_ReturnsFalse()
        {
            var subject = new AnyCharacterNode();

            Assert.That(subject.Equals(null), Is.False);
        }

        [Test]
        public void Equals_WithOtherObject_ReturnsFalse()
        {
            var subject = new AnyCharacterNode();
            var other = new object();

            Assert.That(subject.Equals(other), Is.False);
        }

        [Test]
        public void Equals_WithOtherAnyCharacterNode_ReturnsTrue()
        {
            var subject = new AnyCharacterNode();
            var other = new AnyCharacterNode();

            Assert.That(subject.Equals(other), Is.True);
        }

        [Test]
        public void GetMatches_WhenCharacterIsAvailable_YieldsASingleMatchingElement()
        {
            var subject = new AnyCharacterNode();

            var result = subject.GetMatches("OK", 0).Single();

            Assert.That(result.Value, Is.EqualTo("O"));
        }

        [Test]
        public void GetMatches_AtTheEndOfTheString_YieldsNoElements()
        {
            var subject = new CharacterNode('O');

            var result = subject.GetMatches("OK", 2);

            Assert.That(result, Is.Empty);
        }
    }
}
