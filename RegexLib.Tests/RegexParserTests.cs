//-----------------------------------------------------------------------
// <copyright file="RegexParserTests.cs" company="(none)">
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
    public class RegexParserTests
    {
        [Test]
        public void Parse_WithNullPattern_ThrowsArgumentNullException()
        {
            Assert.That(() => RegexParser.Parse(null, RegexFlavor.JavaScript, RegexOptions.None), Throws.InstanceOf<ArgumentNullException>());
        }

        [Test]
        [TestCase("a", 'a')]
        [TestCase("b", 'b')]
        [TestCase("c", 'c')]
        public void Parse_WithSingleCharacter_YieldsCharacterClassNode(string pattern, char expectedChar)
        {
            var actual = RegexParser.Parse(pattern, RegexFlavor.JavaScript, RegexOptions.None);

            var expected = new CharacterClassNode(expectedChar);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithAlternation_YieldsAlternationNode()
        {
            var actual = RegexParser.Parse("a|b", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new AlternationNode(
                    new CharacterClassNode('a'),
                    new CharacterClassNode('b'));

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithMltipleAlternatives_YieldsNestedAlternationNodes()
        {
            var actual = RegexParser.Parse("a|b|c", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new AlternationNode(
                    new CharacterClassNode('a'),
                    new AlternationNode(
                        new CharacterClassNode('b'),
                        new CharacterClassNode('c')));

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithConcatenation_YieldsConcatenationNode()
        {
            var actual = RegexParser.Parse("ab", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new ConcatenationNode(
                    new CharacterClassNode('a'),
                    new CharacterClassNode('b'));

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithStartAnchor_YieldsStringStartAnchorNode()
        {
            var actual = RegexParser.Parse("^", RegexFlavor.JavaScript, RegexOptions.None);

            var expected = new StringStartAnchorNode();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithEndAnchor_YieldsStringEndAnchorNode()
        {
            var actual = RegexParser.Parse("$", RegexFlavor.JavaScript, RegexOptions.None);

            var expected = new StringEndAnchorNode();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
