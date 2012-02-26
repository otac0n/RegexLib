//-----------------------------------------------------------------------
// <copyright file="CharacterRangeNodeTests.cs" company="(none)">
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
    using System;
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class CharacterRangeNodeTests
    {
        [Test]
        public void ctor_WithCharactersOutOfOrder_ThrowsArgumentOutOfRangeException()
        {
            Assert.That(() => new CharacterRangeNode('z', 'a'), Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void Equals_WithNullReference_ReturnsFalse()
        {
            var subject = new CharacterRangeNode('a', 'z');

            Assert.That(subject.Equals(null), Is.False);
        }

        [Test]
        public void Equals_WithOtherObject_ReturnsFalse()
        {
            var subject = new CharacterRangeNode('a', 'z');
            var other = new object();

            Assert.That(subject.Equals(other), Is.False);
        }

        [Test]
        public void Equals_WithEqualRanges_ReturnsTrue()
        {
            var subject = new CharacterRangeNode('a', 'z');
            var other = new CharacterRangeNode('a', 'z');

            Assert.That(subject.Equals(other), Is.True);
        }

        [Test]
        public void Equals_WithDifferentMinCharacter_ReturnsFalse()
        {
            var subject = new CharacterRangeNode('a', 'z');
            var other = new CharacterRangeNode(char.MinValue, 'z');

            Assert.That(subject.Equals(other), Is.False);
        }

        [Test]
        public void Equals_WithDifferentMaxCharacter_ReturnsFalse()
        {
            var subject = new CharacterRangeNode('a', 'z');
            var other = new CharacterRangeNode('a', char.MaxValue);

            Assert.That(subject.Equals(other), Is.False);
        }

        [Test]
        public void Equals_WithDifferentRange_ReturnsFalse()
        {
            var subject = new CharacterRangeNode('a', 'z');
            var other = new CharacterRangeNode(char.MinValue, char.MaxValue);

            Assert.That(subject.Equals(other), Is.False);
        }

        [Test]
        public void GetMatches_WhenTheCharacterDoesNotMatch_YieldsNoElements()
        {
            var subject = new CharacterRangeNode('1', '9');

            var result = subject.GetMatches("OK", 0);

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void GetMatches_WhenTheCharacterMatches_YieldsASingleMatchingElement()
        {
            var subject = new CharacterRangeNode('A', 'Z');

            var result = subject.GetMatches("OK", 0).Single();

            Assert.That(result.Value, Is.EqualTo("O"));
        }

        [Test]
        public void GetMatches_WhenTheCharacterMatchesMin_YieldsASingleMatchingElement()
        {
            var subject = new CharacterRangeNode('O', 'Z');

            var result = subject.GetMatches("OK", 0).Single();

            Assert.That(result.Value, Is.EqualTo("O"));
        }

        [Test]
        public void GetMatches_WhenTheCharacterMatchesMax_YieldsASingleMatchingElement()
        {
            var subject = new CharacterRangeNode('A', 'O');

            var result = subject.GetMatches("OK", 0).Single();

            Assert.That(result.Value, Is.EqualTo("O"));
        }

        [Test]
        public void GetMatches_AtTheEndOfTheString_YieldsNoElements()
        {
            var subject = new CharacterRangeNode('A', 'Z');

            var result = subject.GetMatches("OK", 2);

            Assert.That(result, Is.Empty);
        }
    }
}
