//-----------------------------------------------------------------------
// <copyright file="AtomicGroupNodeTests.cs" company="(none)">
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
    public class AtomicGroupNodeTests
    {
        [Test]
        public void ctor_WithNullWrappedNode_ThrowsArgumentNullException()
        {
            Assert.That(() => new AtomicGroupNode(null), Throws.InstanceOf<ArgumentNullException>());
        }

        [Test]
        public void Equals_WithNullReference_ReturnsFalse()
        {
            var subject = new AtomicGroupNode(new StubRegexNode());

            Assert.That(subject.Equals(null), Is.False);
        }

        [Test]
        public void Equals_WithOtherObject_ReturnsFalse()
        {
            var subject = new AtomicGroupNode(new StubRegexNode());
            var other = new object();

            Assert.That(subject.Equals(other), Is.False);
        }

        [Theory]
        public void Equals_WithOtherAtomicGroup_MatchesOnlyIfWrappedNodesMatch(bool returnEquals)
        {
            var subject = new AtomicGroupNode(new StubRegexNode(returnEquals));
            var other = new AtomicGroupNode(new StubRegexNode());

            var expected = returnEquals;

            Assert.That(subject.Equals(other), Is.EqualTo(expected));
        }

        [Test]
        public void Matches_WhenWrappedNodeYieldsNone_YieldsNone()
        {
            var subject = new AtomicGroupNode(new StubRegexNode());

            var actual = subject.GetMatches("OK", 0).ToArray();

            Assert.That(actual, Is.Empty);
        }

        [Test]
        public void Matches_WhenWrappedNodeYieldsOne_YieldsThatMatch()
        {
            var matches = new[]
            {
                new RegexMatch("OK", 0, 0),
            };

            var subject = new AtomicGroupNode(new StubRegexNode(matches: matches));

            var actual = subject.GetMatches("OK", 0).ToArray();

            Assert.That(actual, Is.EquivalentTo(matches));
        }

        [Test]
        public void Matches_WhenWrappedNodeYieldsMany_YieldsOnlyFirstMatch()
        {
            var matches = new[]
            {
                new RegexMatch("OK", 0, 0),
                new RegexMatch("OK", 0, 1),
                new RegexMatch("OK", 0, 2),
                new RegexMatch("OK", 1, 0),
                new RegexMatch("OK", 1, 1),
                new RegexMatch("OK", 2, 0),
            };

            var subject = new AtomicGroupNode(new StubRegexNode(matches: matches));

            var actual = subject.GetMatches("OK", 0).ToArray();
            var expected = matches.Take(1).ToArray();

            Assert.That(actual, Is.EquivalentTo(expected));
        }
    }
}
