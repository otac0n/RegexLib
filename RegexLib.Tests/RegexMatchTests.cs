﻿//-----------------------------------------------------------------------
// <copyright file="RegexMatchTests.cs" company="(none)">
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
    using NUnit.Framework;

    [TestFixture]
    public class RegexMatchTests
    {
        [Test]
        public void ctor_WhenGivenANullSubject_ThrowsArgumentNullException()
        {
            Assert.That(() => new RegexMatch(null, 0, 0), Throws.InstanceOf<ArgumentNullException>());
        }

        [Test]
        public void ctor_WhenGivenANegativeStart_ThrowsArgumentOutOfRangeException()
        {
            Assert.That(() => new RegexMatch("OK", -1, 1), Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void ctor_WhenGivenANegativeLength_ThrowsArgumentOutOfRangeException()
        {
            Assert.That(() => new RegexMatch("OK", 1, -1), Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void ctor_WhenGivenAStartPastTheEndOfTheSubject_ThrowsArgumentOutOfRangeException()
        {
            Assert.That(() => new RegexMatch("OK", 3, 0), Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void ctor_WhenGivenALengthPastTheEndOfTheSubject_ThrowsArgumentOutOfRangeException()
        {
            Assert.That(() => new RegexMatch("OK", 0, 3), Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void ctor_WhenGivenASubMatchesCollectionWithANullMatch_ThrowsArgumentOutOfRangeException()
        {
            Assert.That(() => new RegexMatch("OK", 0, 1, new RegexMatch[1]), Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void ctor_WhenGivenAStartAndLengthWithinTheSubject_Succeeds()
        {
            var result = new RegexMatch("OK", 1, 1);

            Assert.Pass();
        }

        [Test]
        public void ctor_WithEmptySubjectAndZeroStartAndLength_Succeeds()
        {
            var result = new RegexMatch(string.Empty, 0, 0);

            Assert.Pass();
        }

        [Test]
        public void ctor_WhenGivenANullSubMatchesCollection_Succeeds()
        {
            var result = new RegexMatch("OK", 0, 1, null);

            Assert.Pass();
        }

        [Test]
        public void ctor_WhenGivenAnEmptySubMatchesCollection_Succeeds()
        {
            var result = new RegexMatch("OK", 0, 1, new RegexMatch[0]);

            Assert.Pass();
        }

        [Test]
        public void Value_WithAStartAndLengthWithinTheSubject_ReturnsProperSubstring()
        {
            var result = new RegexMatch("OK", 1, 1);

            Assert.That(result.Value, Is.EqualTo("K"));
        }

        [Test]
        public void Value_WithZeroLength_ReturnsEmptyString()
        {
            var result = new RegexMatch("OK", 0, 0);

            Assert.That(result.Value, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Equals_WithNullMatch_ReturnsFalse()
        {
            var subject = new RegexMatch("OK", 0, 2);
            var other = (RegexMatch)null;

            Assert.That(subject.Equals(other), Is.False);
        }

        [Test]
        public void Equals_WithIdenticalMatch_ReturnsTrue()
        {
            var subject = new RegexMatch("OK", 0, 2);
            var other = new RegexMatch("OK", 0, 2);

            Assert.That(subject.Equals(other), Is.True);
        }

        [Test]
        public void Equals_WithSameResultInDifferentSubject_ReturnsFalse()
        {
            var subject = new RegexMatch("OK", 0, 2);
            var other = new RegexMatch("OK-Different", 0, 2);

            Assert.That(subject.Equals(other), Is.False);
        }

        [Test]
        public void Equals_WithSameValueFromDifferentStart_ReturnsFalse()
        {
            var subject = new RegexMatch("OK-OK", 0, 2);
            var other = new RegexMatch("OK-OK", 3, 2);

            Assert.That(subject.Equals(other), Is.False);
        }

        [Test]
        public void Equals_WithDifferentLength_ReturnsFalse()
        {
            var subject = new RegexMatch("OK", 0, 2);
            var other = new RegexMatch("OK", 0, 1);

            Assert.That(subject.Equals(other), Is.False);
        }

        [Test]
        public void Equals_WithDifferentSubMatchesCollections_ReturnsFalse()
        {
            var subject = new RegexMatch("OK", 0, 2, new[] { new RegexMatch("OK", 0, 1) });
            var other = new RegexMatch("OK", 0, 2, new[] { new RegexMatch("OK", 0, 2) });

            Assert.That(subject.Equals(other), Is.False);
        }

        [Test]
        public void Equals_WithDifferentSizedSubMatchesCollections_ReturnsFalse()
        {
            var subject = new RegexMatch("OK", 0, 2, new[] { new RegexMatch("OK", 0, 2), new RegexMatch("OK", 0, 1) });
            var other = new RegexMatch("OK", 0, 2, new[] { new RegexMatch("OK", 0, 2) });

            Assert.That(subject.Equals(other), Is.False);
        }

        [Test]
        public void Equals_WithEmptyCollections_ReturnsTrue()
        {
            var subject = new RegexMatch("OK", 0, 2, new RegexMatch[0]);
            var other = new RegexMatch("OK", 0, 2, new RegexMatch[0]);

            Assert.That(subject.Equals(other), Is.True);
        }

        [Test]
        public void Equals_WithOneEmptyCollectionAndOneNullCollection_ReturnsTrue()
        {
            var subject = new RegexMatch("OK", 0, 2, new RegexMatch[0]);
            var other = new RegexMatch("OK", 0, 2, null);

            Assert.That(subject.Equals(other), Is.True);
        }
    }
}
