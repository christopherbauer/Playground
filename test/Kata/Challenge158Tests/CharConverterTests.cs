using System.ComponentModel;
using Challenge158;
using NUnit.Framework;

namespace Challenge158Tests
{
    static class CharacterConverterTests
    {
        [TestFixture]
        public static class when_converting_character_to_string_list
        {
            [Test]
            public static void then_should_convert_a_to_single_plus_sign()
            {
                // Arrange
                const char character = 'a';

                // Act
                var convertedValue = CharacterConverter.ToColumnValues(character);

                // Assert
                Assert.That(convertedValue, Is.EqualTo(new[] {'+'}));
            }
            [Test]
            public static void then_should_convert_j_to_plus_plus_dash_dash_asterisk_asterisk_asterisk_period_period_period()
            {
                // Arrange
                const char character = 'j';

                // Act
                var convertedValue = CharacterConverter.ToColumnValues(character);

                // Assert
                Assert.That(convertedValue, Is.EqualTo(
                    new[]
                    {
                        '+', '+', '-', '-', '*', '*', '*', '.', '.', '.'
                    }));
            }
        }
    }
}
