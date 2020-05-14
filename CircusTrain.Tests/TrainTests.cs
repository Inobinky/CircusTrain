using CircusTrain.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircusTrain.Tests
{
    [TestClass]
    public class TrainTests
    {
        [TestMethod]
        public void No_Animals_Lead_To_0_Wagons()
        {
            // Arrange
            Train t = new Train();

            // Act
            t.DistributeAnimals();

            // Assert
            Assert.AreEqual(0, t.WagonCount); 
        }
    }
}
