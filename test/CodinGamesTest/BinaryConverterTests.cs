using CodinGamesPlayground;
using NUnit.Framework;

namespace CodinGamesTest
{
    public class BinaryConverterTests
    {
        [TestFixture]
        public static class when_converting_to_binary_string
        {
            [Test]
            public static void then_should_return_01000011_given_C()
            {
                // Arrange
                var binaryConverter = new BinaryConverter();

                // Act
                var binaryString = binaryConverter.StringToBinary("C");

                // Assert
                Assert.That(binaryString,Is.EqualTo("1000011"));
            }
            [Test]
            public static void then_should_return_10000111000011_given_CC()
            {
                // Arrange
                var binaryConverter = new BinaryConverter();

                // Act
                var binaryString = binaryConverter.StringToBinary("CC");

                // Assert
                Assert.That(binaryString, Is.EqualTo("10000111000011"));
            }
        }

        [TestFixture]
        public static class when_converting_to_unary_string
        {
            [Test]
            public static void then_should_return_0_0_00_0000_0_00_given_01000011()
            {
                // Arrange
                var binaryConverter = new BinaryConverter();

                // Act
                var unaryString = binaryConverter.BinaryStringToUnary("1000011");

                // Assert
                Assert.That(unaryString, Is.EqualTo("0 0 00 0000 0 00"));
            }
            [Test]
            public static void then_should_return_0_0_00_0000_0_000_00_0000_0_00_given_10000111000011()
            {
                // Arrange
                var binaryConverter = new BinaryConverter();

                // Act
                var unaryString = binaryConverter.BinaryStringToUnary("10000111000011");

                // Assert
                Assert.That(unaryString, Is.EqualTo("0 0 00 0000 0 000 00 0000 0 00"));
            }
            [Test]
            public static void then_should_return_00_0_0_0_00_00_0_0_00_0_0_0_given_10000111000011()
            {
                // Arrange
                var binaryConverter = new BinaryConverter();

                // Act
                var unaryString = binaryConverter.BinaryStringToUnary("0100101");

                // Assert
                Assert.That(unaryString, Is.EqualTo("00 0 0 0 00 00 0 0 00 0 0 0"));
            }
        }
    }
}