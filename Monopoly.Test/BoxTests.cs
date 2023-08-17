using Monopoly.Entities;

namespace Monopoly.Test
{
    [TestClass]
    public class BoxTests
    {
        [TestMethod]
        public void CalculationVolume_ShouldCalculateCorrectVolume()
        {
            // Arrange
            var box = new Box(1, 10, 5, 7, 2, new DateOnly(2023, 8, 17));

            // Act
            var volume = box.CalculationVolume();

            // Assert
            Assert.AreEqual(10 * 5 * 7, volume);
        }

        [TestMethod]
        public void CreatedDate_ShouldSetExpirationDateCorrectly()
        {
            // Arrange
            var createdDate = new DateOnly(2023, 8, 1);
            var expectedExpirationDate = createdDate.AddDays(100);

            // Act
            var box = new Box(1, 10, 5, 7, 2, new DateOnly(2023, 8, 17));
            box.CreatedDate = createdDate;

            // Assert
            Assert.AreEqual(expectedExpirationDate, box.ExpirationDate);
        }
    }
}
