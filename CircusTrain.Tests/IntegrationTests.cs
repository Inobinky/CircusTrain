using CircusTrain.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CircusTrain.Tests
{
    [TestClass]
    public class IntegrationTests
    {
        private Train _train;
        private List<Animal> _animals;

        [TestInitialize]
        public void Setup()
        {
            _train = new Train();
            _animals = new List<Animal>();
        }

        [TestMethod]
        public void CircusTrain_Integration_Test_1()
        {
            // Arrange

            // Act
            for (int i = 0; i < 3; i++) // Adds 18 animals in total. It 'simulates' the AddAnimals function in AnimalFactory.cs
            {
                _animals.Add(AnimalFactory.SmallCarnivore);
                _animals.Add(AnimalFactory.MediumCarnivore);
                _animals.Add(AnimalFactory.LargeCarnivore);

                _animals.Add(AnimalFactory.SmallHerbivore);
                _animals.Add(AnimalFactory.MediumHerbivore);
                _animals.Add(AnimalFactory.LargeHerbivore);
            }
            _train.AddAnimals(_animals);

            _train.DistributeAnimals();

            // Assert
            Assert.IsNotNull(_train);
            Assert.IsNotNull(_animals);

            foreach (Wagon wagon in _train.Wagons)
            {
                Assert.IsNotNull(wagon);
                Assert.IsTrue(wagon.Animals.Any());
            }

            Assert.AreEqual(18, _animals.Count);
            Assert.AreEqual(10, _train.WagonCount);
        }

        [TestMethod]
        public void Full_Integration_Test()
        {
            // Arrange

            // Act
            for (int i = 0; i < 5; i++) { _animals.Add(AnimalFactory.SmallHerbivore); }
            for (int i = 0; i < 5; i++) { _animals.Add(AnimalFactory.LargeHerbivore); }
            for (int i = 0; i < 5; i++) { _animals.Add(AnimalFactory.MediumHerbivore); }
            for (int i = 0; i < 2; i++) { _animals.Add(AnimalFactory.SmallCarnivore); }
            for (int i = 0; i < 2; i++) { _animals.Add(AnimalFactory.MediumCarnivore); }
            for (int i = 0; i < 2; i++) { _animals.Add(AnimalFactory.LargeCarnivore); }

            _train.AddAnimals(_animals);
            _train.DistributeAnimals();

            // Assert
            Assert.IsNotNull(_train);
            Assert.IsNotNull(_animals);

            foreach (Wagon wagon in _train.Wagons)
            {
                Assert.IsNotNull(wagon);
                Assert.IsTrue(wagon.Animals.Any());
            }

            Assert.AreEqual(8, _train.WagonCount);
            Assert.AreEqual(21, _animals.Count);
            Assert.AreEqual(6, _animals.OfType<Carnivore>().Count());
            Assert.AreEqual(15, _animals.OfType<Herbivore>().Count());
        }
    }
}
