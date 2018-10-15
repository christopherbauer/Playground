using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge180;
using NUnit.Framework;

namespace Challenge180Tests
{
    class TamagatchiTests
    {
        [TestFixture]
        public static class when_creating_a_tamagatchi
        {
            [Test]
            public static void then_should_initialize_age_to_one()
            {
                // Arrange
                var tamagatchi = new Tamagatchi();

                // Act
                

                // Assert
                Assert.That(tamagatchi.Age, Is.EqualTo(1));
            }
            [Test]
            public static void then_should_initialize_hunger_to_five()
            {
                // Arrange
                var tamagatchi = new Tamagatchi();

                // Act
                

                // Assert
                Assert.That(tamagatchi.Hunger, Is.EqualTo(5));
            }
            [Test]
            public static void then_should_initialize_play_to_five()
            {
                // Arrange
                var tamagatchi = new Tamagatchi();

                // Act
                

                // Assert
                Assert.That(tamagatchi.Play, Is.EqualTo(5));
            }
            [Test]
            public static void then_should_initialize_feedings_to_zero()
            {
                // Arrange
                var tamagatchi = new Tamagatchi();

                // Act
                

                // Assert
                Assert.That(tamagatchi.Feedings, Is.EqualTo(0));
            }

            [Test]
            public static void then_should_initialize_status_to_sleeping()
            {
                // Arrange
                var tamagatchi = new Tamagatchi();

                // Act
                

                // Assert
                Assert.That(tamagatchi.TamagatchiStatus, Is.EqualTo(TamagatchiStatus.Sleeping));
            }
        }

        [TestFixture]
        public static class when_feeding_tamagatchi
        {
            [Test]
            public static void then_should_add_food_value_to_hunger()
            {
                // Arrange
                var tamagatchi = new Tamagatchi
                {
                    Hunger = 1
                };

                // Act
                tamagatchi.Feed(1);

                // Assert
                Assert.That(tamagatchi.Hunger, Is.EqualTo(2));
            }

            [Test]
            public static void then_should_add_one_to_feedings()
            {
                // Arrange
                var tamagatchi = new Tamagatchi
                {
                    Feedings = 1
                };

                // Act
                tamagatchi.Feed(1);

                // Assert
                Assert.That(tamagatchi.Feedings, Is.EqualTo(2));
            }
            [Test]
            public static void then_should_add_one_to_feedings_if_food_value_is_two()
            {
                // Arrange
                var tamagatchi = new Tamagatchi
                {
                    Feedings = 1
                };

                // Act
                tamagatchi.Feed(2);

                // Assert
                Assert.That(tamagatchi.Feedings, Is.EqualTo(2));
            }
        }

        [TestFixture]
        public static class when_putting_tamagatchi_to_Bed
        {
            [Test]
            public static void then_should_sleep_if_not_fully_rested()
            {
                // Arrange
                var tamagatchi = new Tamagatchi();

                // Act
                var status = tamagatchi.PutToBed();

                // Assert
                Assert.That(status, Is.True);
            }
        }
    }
}
