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

            var expected = new CharacterClassNode('a');

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithCharacterRangeStartingWithCharacterClass_ThrowsFormatException()
        {
            Assert.That(
                () => RegexParser.Parse(@"[\w-c]", RegexFlavor.JavaScript, RegexOptions.None),
                Throws.InstanceOf<FormatException>());
        }

        [Test]
        public void Parse_WithCharacterRangeEndingWithCharacterClass_ThrowsFormatException()
        {
            Assert.That(
                () => RegexParser.Parse(@"[a-\w]", RegexFlavor.JavaScript, RegexOptions.None),
                Throws.InstanceOf<FormatException>());
        }

        [Test]
        public void Parse_WithCharacterClassWithOutOfOrderCharacters_ThrowsFormatException()
        {
            Assert.That(
                () => RegexParser.Parse(@"[z-a]", RegexFlavor.JavaScript, RegexOptions.None),
                Throws.InstanceOf<FormatException>());
        }

        [Test]
        public void Parse_WithCharacterWithRange_ReturnsTheRange()
        {
            var actual = RegexParser.Parse(@"[a-z]", RegexFlavor.JavaScript, RegexOptions.None);

            var expected = new CharacterClassNode('a', 'z');

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithStarRepetition_ReturnsRepetition()
        {
            var actual = RegexParser.Parse(@"a*", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new RepetitionNode(
                    new CharacterClassNode('a'),
                    0,
                    null,
                    true);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithLazyStarRepetition_ReturnsRepetition()
        {
            var actual = RegexParser.Parse(@"a*?", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new RepetitionNode(
                    new CharacterClassNode('a'),
                    0,
                    null,
                    false);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithPlusRepetition_ReturnsRepetition()
        {
            var actual = RegexParser.Parse(@"a+", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new RepetitionNode(
                    new CharacterClassNode('a'),
                    1,
                    null,
                    true);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithLazyPlusRepetition_ReturnsRepetition()
        {
            var actual = RegexParser.Parse(@"a+?", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new RepetitionNode(
                    new CharacterClassNode('a'),
                    1,
                    null,
                    false);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithOptionalModifier_ReturnsRepetition()
        {
            var actual = RegexParser.Parse(@"a?", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new RepetitionNode(
                    new CharacterClassNode('a'),
                    0,
                    1,
                    true);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithLazyOptionalModifier_ReturnsRepetition()
        {
            var actual = RegexParser.Parse(@"a??", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new RepetitionNode(
                    new CharacterClassNode('a'),
                    0,
                    1,
                    false);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithRepititionIndicatorWithSingleNumber_ReturnsRepetition()
        {
            var actual = RegexParser.Parse(@"a{2}", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new RepetitionNode(
                    new CharacterClassNode('a'),
                    2,
                    2,
                    true);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithLazyRepititionIndicatorWithSingleNumber_ReturnsRepetition()
        {
            var actual = RegexParser.Parse(@"a{2}?", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new RepetitionNode(
                    new CharacterClassNode('a'),
                    2,
                    2,
                    false);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithRepititionIndicatorWithNoUpperLimit_ReturnsRepetition()
        {
            var actual = RegexParser.Parse(@"a{2,}", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new RepetitionNode(
                    new CharacterClassNode('a'),
                    2,
                    null,
                    true);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithLazyRepititionIndicatorWithNoUpperLimit_ReturnsRepetition()
        {
            var actual = RegexParser.Parse(@"a{2,}?", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new RepetitionNode(
                    new CharacterClassNode('a'),
                    2,
                    null,
                    false);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithRepititionIndicatorWithUpperLimit_ReturnsRepetition()
        {
            var actual = RegexParser.Parse(@"a{2,3}", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new RepetitionNode(
                    new CharacterClassNode('a'),
                    2,
                    3,
                    true);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithLazyRepititionIndicatorWithUpperLimit_ReturnsRepetition()
        {
            var actual = RegexParser.Parse(@"a{2,3}?", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new RepetitionNode(
                    new CharacterClassNode('a'),
                    2,
                    3,
                    false);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithRepititionIndicatorWithUpperLimitGreaterThanLowerLimit_ThrowsFormatException()
        {
            Assert.That(() => RegexParser.Parse(@"a{3,2}", RegexFlavor.JavaScript, RegexOptions.None), Throws.InstanceOf<FormatException>());
        }

        [Test]
        public void Parse_WithLazyRepititionIndicatorWithUpperLimitGreaterThanLowerLimit_ThrowsFormatException()
        {
            Assert.That(() => RegexParser.Parse(@"a{3,2}?", RegexFlavor.JavaScript, RegexOptions.None), Throws.InstanceOf<FormatException>());
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

            var expected = new CharacterClassNode(specialChar);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithWordCharacterClass_ReturnsRangesEncompasingExpectedRange()
        {
            var actual = RegexParser.Parse(@"\w", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new CharacterClassNode(
                    new CharacterClassNode.CharacterRange('a', 'z'),
                    new CharacterClassNode.CharacterRange('A', 'Z'),
                    new CharacterClassNode.CharacterRange('0', '9'),
                    new CharacterClassNode.CharacterRange('_', '_'));

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithMultipleCharacters_YieldsConcatenation()
        {
            var actual = RegexParser.Parse(@"ab", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new ConcatenationNode(
                    new CharacterClassNode('a'),
                    new CharacterClassNode('b'));

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_WithAlternation_YieldsAlternation()
        {
            var actual = RegexParser.Parse(@"a|b", RegexFlavor.JavaScript, RegexOptions.None);

            var expected =
                new AlternationNode(
                    new CharacterClassNode('a'),
                    new CharacterClassNode('b'));

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
