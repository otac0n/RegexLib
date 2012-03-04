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
        public void Parse_WithSingleCharacter_YieldsCharacterNode()
        {
            var actual = RegexParser.Parse(@"a", RegexFlavor.JavaScript, RegexOptions.None);

            var expected = new CharacterNode('a');

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithCharacterRangeStartingWithCharacterClass_ThrowsFormatException()
        {
            Assert.That(
                () => RegexParser.Parse(@"^[\w-c]$", RegexFlavor.JavaScript, RegexOptions.None),
                Throws.InstanceOf<FormatException>());
        }

        [Test]
        public void Parse_WithCharacterRangeEndingWithCharacterClass_ThrowsFormatException()
        {
            Assert.That(
                () => RegexParser.Parse(@"^[a-/w]$", RegexFlavor.JavaScript, RegexOptions.None),
                Throws.InstanceOf<FormatException>());
        }

        [Test]
        public void Parse_WithCharacterClassWithOutOfOrderCharacters_ThrowsFormatException()
        {
            Assert.That(
                () => RegexParser.Parse(@"^[z-a]$", RegexFlavor.JavaScript, RegexOptions.None),
                Throws.InstanceOf<FormatException>());
        }

        [Test]
        public void Parse_WithUnmatchedSlash_ThrowsFormatException()
        {
            Assert.That(
                () => RegexParser.Parse(@"\", RegexFlavor.JavaScript, RegexOptions.None),
                Throws.InstanceOf<FormatException>());
        }

        [Test(Description = "SyntaxError was thrown when max is finite and less than min (ECMA262 §15.10.2.5 step 3)")]
        public void Parse_WithRepetitionMinGreaterThanMax_ThrowsFormatException()
        {
            Assert.That(
                () => RegexParser.Parse(@"0{2,1}", RegexFlavor.JavaScript, RegexOptions.None),
                Throws.InstanceOf<FormatException>());
        }

        [Test]
        [TestCase(@"\0", '\u0000')]
        [TestCase(@"\t", '\u0009')]
        [TestCase(@"\n", '\u000A')]
        [TestCase(@"\v", '\u000B')]
        [TestCase(@"\f", '\u000C')]
        [TestCase(@"\r", '\u000D')]
        public void Parse_WithSpecialCharacters_MatchesExpectedCharacters(string pattern, char specialChar)
        {
            var actual = RegexParser.Parse(pattern, RegexFlavor.JavaScript, RegexOptions.None);

            var expected = new CharacterNode(specialChar);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithWordCharacterClass_ReturnsRangesEncompasingExpectedRange()
        {
            var actual = RegexParser.Parse(@"\w", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new AlternationNode(
                    new CharacterNode('a', 'z'),
                    new AlternationNode(
                        new CharacterNode('A', 'Z'),
                        new AlternationNode(
                            new CharacterNode('0', '9'),
                            new CharacterNode('_'))));

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithMultipleCharacters_YieldsConcatenation()
        {
            var actual = RegexParser.Parse(@"abc", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new ConcatenationNode(
                    new CharacterNode('a'),
                    new ConcatenationNode(
                        new CharacterNode('b'),
                        new CharacterNode('c')));

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithAlternation_YieldsAlternation()
        {
            var actual = RegexParser.Parse(@"a|ab", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new AlternationNode(
                    new CharacterNode('a'),
                    new ConcatenationNode(
                        new CharacterNode('a'),
                        new CharacterNode('b')));

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
