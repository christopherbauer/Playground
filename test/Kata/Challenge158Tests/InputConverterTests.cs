using Challenge158;
using Moq;
using NUnit.Framework;

namespace Challenge158Tests
{
    public static class InputConverterTests
    {
        [TestFixture]
        public static class when_input_converter_is_converting
        {
            [Test]
            public static void then_should_print_out_the_map_for_j()
            {
                // Arrange
                const string inputString = "j";
                var outputDevice = new StringOutputDevice();
                var inputConverter = new InputConverter(outputDevice, inputString);

                // Act
                inputConverter.Convert();

                // Assert
                Assert.That(outputDevice.Output, Is.EqualTo("++--***..."));
            }
            [Test]
            public static void then_should_print_out_the_map_for_i()
            {
                // Arrange
                const string inputString = "i";
                var outputDevice = new StringOutputDevice();
                var inputConverter = new InputConverter(outputDevice, inputString);

                // Act
                inputConverter.Convert();

                // Assert
                Assert.That(outputDevice.Output, Is.EqualTo("++--***.."));
            }

            [Test]
            public static void then_should_print_out_floating_map_of_a_for_input_1a()
            {
                // Arrange
                const string inputString = "1a";
                var outputDevice = new StringOutputDevice();
                var inputConverter = new InputConverter(outputDevice, inputString);
                
                // Act
                inputConverter.Convert();

                // Assert
                Assert.That(outputDevice.Output, Is.EqualTo(" +"));
            }

            [Test]
            public static void then_should_convert_complex_string_to_full_map()
            {
                // Arrange
                const string inputString = "j3f3e3e3d3d3c3cee3c3c3d3d3e3e3f3fjij3f3f3e3e3d3d3c3cee3c3c3d3d3e3e3fj";
                var outputDevice = new Mock<IOutputDevice>();
                var inputConverter = new InputConverter(outputDevice.Object, inputString);

                // Act
                inputConverter.Convert();

                // Assert
                outputDevice.Verify(device => device.Write("++--***..."));
                outputDevice.Verify(device => device.Write("   ++--** "));
            }
        }
    }
}