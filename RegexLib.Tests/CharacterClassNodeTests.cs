// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace RegexLib.Tests
{
    using System;
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class CharacterClassNodeTests
    {
        [Datapoints]
        public char[] Chars =
        {
            '\u0041', // Uppercase Letter
            '\u0061', // Lowercase Letter
            '\u01C5', // Titlecase Letter
            '\u02B0', // Modifier Letter
            '\u05D0', // Other Letter
            '\u0610', // Non-spacing Mark
            '\u0903', // SpacingCombiningMark
            '\u20DD', // EnclosingMark
            '\uA620', // Decimal Digit Number
            '\uA6E6', // Letter Number
            '\uA830', // Other Number
            '\u0020', // Space Separator
            '\u2028', // Line Separator
            '\u2029', // Paragraph Separator
            '\u0000', // Control
            '\u00AD', // Format
            '\u060C', // Surrogate
            '\uE000', // Private Use
            '\u005F', // Connector Punctuation
            '\u002D', // Dash Punctuation
            '\u0028', // Open Punctuation
            '\u0029', // Close Punctuation
            '\u2018', // Initial Quote Punctuation
            '\u2019', // Final Quote Punctuation
            '\u0021', // Other Punctuation
            '\u002B', // Math Symbol
            '\u0024', // Currency Symbol
            '\u005E', // Modifier Symbol
            '\u00A6', // Other Symbol
        };

        [Test]
        public void ctor_WithCharactersOutOfOrder_ThrowsArgumentOutOfRangeException()
        {
            Assert.That(() => new CharacterClassNode('z', 'a'), Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void Equals_WhenRangesAreEquivalent_ReturnsTrue()
        {
            var subject = new CharacterClassNode(
                new CharacterRange(char.MinValue, 'a'),
                new CharacterRange('a', 'v'),
                new CharacterRange('m', 'q'),
                new CharacterRange('w', 'w'),
                new CharacterRange('x', 'x'),
                new CharacterRange('y', 'y'),
                new CharacterRange('z', char.MaxValue));
            var other = new CharacterClassNode();

            Assert.That(subject.Equals(other), Is.True);
        }

        [Test]
        public void Equals_WhenRangesAreMerged_ReturnsTrue()
        {
            var subject = new CharacterClassNode(
                new CharacterRange('a', 'a'),
                new CharacterRange('b', 'b'),
                new CharacterRange('c', 'c'));
            var other = new CharacterClassNode('a', 'c');

            Assert.That(subject.Equals(other), Is.True);
        }

        [Test]
        public void Equals_WhenRangesAreNotEquivalent_ReturnsFalse()
        {
            var subject = new CharacterClassNode();
            var other = new CharacterClassNode();

            Assert.That(subject.Equals(other), Is.True);
        }

        [Test]
        public void Equals_WhenRangesAreSuppressed_ReturnsTrue()
        {
            var subject = new CharacterClassNode(
                new CharacterRange('a', 'c'),
                new CharacterRange('a', 'b'),
                new CharacterRange('b', 'c'));
            var other = new CharacterClassNode('a', 'c');

            Assert.That(subject.Equals(other), Is.True);
        }

        [Test]
        public void Equals_WithDifferentMaxCharacter_ReturnsFalse()
        {
            var subject = new CharacterClassNode('a', 'z');
            var other = new CharacterClassNode('a', char.MaxValue);

            Assert.That(subject.Equals(other), Is.False);
        }

        [Test]
        public void Equals_WithDifferentMinCharacter_ReturnsFalse()
        {
            var subject = new CharacterClassNode('a', 'z');
            var other = new CharacterClassNode(char.MinValue, 'z');

            Assert.That(subject.Equals(other), Is.False);
        }

        [Test]
        public void Equals_WithDifferentRange_ReturnsFalse()
        {
            var subject = new CharacterClassNode('a', 'z');
            var other = new CharacterClassNode(char.MinValue, char.MaxValue);

            Assert.That(subject.Equals(other), Is.False);
        }

        [Test]
        public void Equals_WithEqualRanges_ReturnsTrue()
        {
            var subject = new CharacterClassNode('a', 'z');
            var other = new CharacterClassNode('a', 'z');

            Assert.That(subject.Equals(other), Is.True);
        }

        [Test]
        public void Equals_WithNullReference_ReturnsFalse()
        {
            var subject = new CharacterClassNode('a');

            Assert.That(subject.Equals(null), Is.False);
        }

        [Test]
        public void Equals_WithOtherAnyCharacterNode_ReturnsTrue()
        {
            var subject = new CharacterClassNode();
            var other = new CharacterClassNode();

            Assert.That(subject.Equals(other), Is.True);
        }

        [Theory]
        public void Equals_WithOtherCharacterNode_MatchesCharacterEquality(char c1, char c2)
        {
            var subject = new CharacterClassNode(c1);
            var other = new CharacterClassNode(c2);

            var expected = c1 == c2;

            Assert.That(subject.Equals(other), Is.EqualTo(expected));
        }

        [Test]
        public void Equals_WithOtherObject_ReturnsFalse()
        {
            var subject = new CharacterClassNode('a');
            var other = new object();

            Assert.That(subject.Equals(other), Is.False);
        }

        [Test]
        public void GetMatches_AtTheEndOfTheString_YieldsNoElements()
        {
            var subject = new CharacterClassNode('O');

            var result = subject.GetMatches("OK", 2);

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void GetMatches_WhenCharacterIsAvailable_YieldsASingleMatchingElement()
        {
            var subject = new CharacterClassNode();

            var result = subject.GetMatches("OK", 0).Single();

            Assert.That(result.Value, Is.EqualTo("O"));
        }

        [Theory]
        public void GetMatches_WhenTheCharacterDoesNotMatch_YieldsNoElements(char c)
        {
            Assume.That(c, Is.Not.EqualTo('O'));

            var subject = new CharacterClassNode(c);

            var result = subject.GetMatches("OK", 0);

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void GetMatches_WhenTheCharacterMatches_YieldsASingleMatchingElement()
        {
            var subject = new CharacterClassNode('O');

            var result = subject.GetMatches("OK", 0).Single();

            Assert.That(result.Value, Is.EqualTo("O"));
        }

        [Test]
        public void GetMatches_WhenTheCharacterRangeDoesNotMatch_YieldsNoElements()
        {
            var subject = new CharacterClassNode('1', '9');

            var result = subject.GetMatches("OK", 0);

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void GetMatches_WhenTheCharacterRangeMatches_YieldsASingleMatchingElement()
        {
            var subject = new CharacterClassNode('A', 'Z');

            var result = subject.GetMatches("OK", 0).Single();

            Assert.That(result.Value, Is.EqualTo("O"));
        }

        [Test]
        public void GetMatches_WhenTheCharacterRangeMatchesMax_YieldsASingleMatchingElement()
        {
            var subject = new CharacterClassNode('A', 'O');

            var result = subject.GetMatches("OK", 0).Single();

            Assert.That(result.Value, Is.EqualTo("O"));
        }

        [Test]
        public void GetMatches_WhenTheCharacterRangeMatchesMin_YieldsASingleMatchingElement()
        {
            var subject = new CharacterClassNode('O', 'Z');

            var result = subject.GetMatches("OK", 0).Single();

            Assert.That(result.Value, Is.EqualTo("O"));
        }
    }
}
