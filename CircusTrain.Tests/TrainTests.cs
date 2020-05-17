using CircusTrain.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircusTrain.Tests
{
    [TestClass]
    public class TrainTests
    {
        private Train _train;

        [TestInitialize]
        public void Setup()
        {
            _train = new Train();
        }

        [TestMethod]
        public void No_Animals_Lead_To_0_Wagons()
        {
            // Arrange

            // Act
            _train.DistributeAnimals();

            // Assert
            Assert.AreEqual(0, _train.WagonCount); 
        }

        [TestMethod]
        public void Four_Large_Herbivores_Fit_In_Two_Wagons()
        {
            // Arrange

            // Act
            for (int i = 0; i < 4; i++)
            {
                _train.AddAnimal(AnimalFactory.LargeHerbivore);
            }
            _train.DistributeAnimals();

            // Assert
            Assert.AreEqual(2, _train.WagonCount);
        }

        [TestMethod]
        public void OneHundred_LargeCarnivores_Lead_To_OneHundred_Wagons()
        {
            // Arrange

            // Act
            for (int i = 0; i < 100; i++)
            {
                _train.AddAnimal(AnimalFactory.LargeCarnivore);
            }
            _train.DistributeAnimals();

            // Assert
            Assert.AreEqual(100, _train.WagonCount);
        }

        [TestMethod]
        public void OneHundred_MediumHerbivores_Lead_To_ThirtyFour_Wagons()
        {
            // Arrange

            // Act
            for (int i = 0; i < 100; i++)
            {
                _train.AddAnimal(AnimalFactory.MediumHerbivore);
            }
            _train.DistributeAnimals();

            // Assert
            Assert.AreEqual(34, _train.WagonCount);
        }
    }
}
