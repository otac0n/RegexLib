//-----------------------------------------------------------------------
// <copyright file="ConcatenationNodeTests.cs" company="(none)">
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
    public class ConcatenationNodeTests
    {
        [Test]
        public void ctor_WithNullA_ThrowsArgumentNullException()
        {
            Assert.That(() => new ConcatenationNode(null, new StubRegexNode()), Throws.InstanceOf<ArgumentNullException>());
        }

        [Test]
        public void ctor_WithNullB_ThrowsArgumentNullException()
        {
            Assert.That(() => new ConcatenationNode(new StubRegexNode(), null), Throws.InstanceOf<ArgumentNullException>());
        }

        [Test]
        public void Equals_WithNullReference_ReturnsFalse()
        {
            var subject = new ConcatenationNode(
                new StubRegexNode(),
                new StubRegexNode());

            Assert.That(subject.Equals(null), Is.False);
        }

        [Test]
        public void Equals_WithOtherObject_ReturnsFalse()
        {
            var subject = new ConcatenationNode(
                new StubRegexNode(),
                new StubRegexNode());
            var other = new object();

            Assert.That(subject.Equals(other), Is.False);
        }

        [Theory]
        public void Equals_WithOtherConcatenation_MatchesOnlyIfBothElementsMatch(bool returnEqualsA, bool returnEqualsB)
        {
            var subject = new ConcatenationNode(
                new StubRegexNode(returnEqualsA),
                new StubRegexNode(returnEqualsB));
            var other = new ConcatenationNode(
                new StubRegexNode(),
                new StubRegexNode());

            var expected = (returnEqualsA && returnEqualsB);

            Assert.That(subject.Equals(other), Is.EqualTo(expected));
        }

        [Test]
        public void Matches_WhenADoesNotMatch_YieldsNone()
        {
            var bMatches = new[] { new RegexMatch("OK", 0, 1) };

            var subject = new ConcatenationNode(
                new StubRegexNode(),
                new StubRegexNode(matches: bMatches));

            var result = subject.GetMatches("OK", 0).ToList();

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Matches_WhenBDoesNotMatch_YieldsNone()
        {
            var aMatches = new[] { new RegexMatch("OK", 0, 1) };

            var subject = new ConcatenationNode(
                new StubRegexNode(matches: aMatches),
                new StubRegexNode());

            var result = subject.GetMatches("OK", 0).ToList();

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Matches_WhenBothMatch_YieldsConcatenation()
        {
            var aMatches = new[] { new RegexMatch("OK", 0, 1) };
            var bMatches = new[] { new RegexMatch("OK", 1, 1) };

            var subject = new ConcatenationNode(
                new StubRegexNode(matches: aMatches),
                new StubRegexNode(matches: bMatches));

            var result = subject.GetMatches("OK", 0).ToList();

            var expected = (from a in aMatches
                            from b in bMatches
                            select new RegexMatch("OK", 0, 2, new[] { a, b })).ToList();

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void Matches_WhenAMatchesMultipleTimes_YieldsConcatenation()
        {
            var aMatches = new[] { new RegexMatch("OK", 0, 1), new RegexMatch("OK", 0, 1) };
            var bMatches = new[] { new RegexMatch("OK", 1, 1) };

            var subject = new ConcatenationNode(
                new StubRegexNode(matches: aMatches),
                new StubRegexNode(matches: bMatches));

            var result = subject.GetMatches("OK", 0).ToList();

            var expected = (from a in aMatches
                            from b in bMatches
                            select new RegexMatch("OK", 0, 2, new[] { a, b })).ToList();

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void Matches_WhenBMatchesMultipleTimes_YieldsConcatenation()
        {
            var aMatches = new[] { new RegexMatch("OK", 0, 1) };
            var bMatches = new[] { new RegexMatch("OK", 1, 1), new RegexMatch("OK", 1, 1) };

            var subject = new ConcatenationNode(
                new StubRegexNode(matches: aMatches),
                new StubRegexNode(matches: bMatches));

            var result = subject.GetMatches("OK", 0).ToList();

            var expected = (from a in aMatches
                            from b in bMatches
                            select new RegexMatch("OK", 0, 2, new[] { a, b })).ToList();

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void Matches_WhenBothMatchMultipleTimes_YieldsConcatenation()
        {
            var aMatches = new[] { new RegexMatch("OK", 0, 1), new RegexMatch("OK", 0, 1) };
            var bMatches = new[] { new RegexMatch("OK", 1, 1), new RegexMatch("OK", 1, 1) };

            var subject = new ConcatenationNode(
                new StubRegexNode(matches: aMatches),
                new StubRegexNode(matches: bMatches));

            var result = subject.GetMatches("OK", 0).ToList();

            var expected = (from a in aMatches
                            from b in bMatches
                            select new RegexMatch("OK", 0, 2, new[] { a, b })).ToList();

            Assert.That(result, Is.EquivalentTo(expected));
        }
    }
}
