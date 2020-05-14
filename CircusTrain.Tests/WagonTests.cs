using CircusTrain.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircusTrain.Tests
{
    [TestClass]
    public class WagonTests
    {
        private Wagon _wagon;

        [TestInitialize]
        public void Setup()
        {
            _wagon = new Wagon();
        }

        [TestMethod]
        public void Wagon_Can_Be_Constructed_With_Default_Capacity()
        {
            // Arrange

            // Act

            // Assert
            Assert.IsNotNull(_wagon);
            Assert.AreEqual(10, _wagon.Capacity);
        }

        [TestMethod]
        public void When_Animal_Is_Added_Capacity_Is_Lower()
        {
            // Arrange
            Animal a = AnimalFactory.LargeHerbivore;
            int originalCapacity = _wagon.Capacity;
            int animalSize = (int)a.size;
            int expectedCapacity = originalCapacity - animalSize;

            // Act
            _wagon.AddAnimal(a);

            // Assert
            Assert.AreEqual(expectedCapacity, _wagon.Capacity);
        }

        [TestMethod]
        [ExpectedException(typeof(WagonSafetyException))]
        public void Cant_Add_Herbivore_With_SameSize_Or_Bigger_Carnivore()
        {
            // Arrange
            _wagon.AddAnimal(AnimalFactory.MediumCarnivore);

            // Act
            _wagon.AddAnimal(AnimalFactory.MediumHerbivore);
        }
    }
}
