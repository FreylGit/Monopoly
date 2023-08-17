using Monopoly.Entities;

namespace Monopoly.Test
{
    [TestClass]
    public class PalletTests
    {
        [TestMethod]
        public void CalculationVolume_ShouldCalculateCorrectVolume()
        {
            // Arrange
            var pallet = new Pallet(1, 10, 5, 7);
            var box1 = new Box(1, 5, 3, 2, 1, new DateOnly(2023, 8, 17));
            var box2 = new Box(2, 3, 4, 2, 0.5, new DateOnly(2023, 9, 1));
            pallet.AddBox(box1);
            pallet.AddBox(box2);

            // Act
            var volume = pallet.CalculationVolume();

            // Assert
            Assert.AreEqual(10 * 7 + box1.CalculationVolume() + box2.CalculationVolume(), volume);
        }

        [TestMethod]
        public void ExpirationDate_ShouldReturnMinExpirationDateFromBoxes()
        {
            // Arrange
            var pallet = new Pallet(1, 10, 5, 7);
            var box1 = new Box(1, 5, 3, 2, 1, new DateOnly(2023, 8, 17));
            var box2 = new Box(2, 3, 4, 2, 0.5, new DateOnly(2023, 9, 1));
            pallet.AddBox(box1);
            pallet.AddBox(box2);

            // Act
            var expirationDate = pallet.ExpirationDate;

            // Assert
            Assert.AreEqual(box1.ExpirationDate, expirationDate);
        }

        [TestMethod]
        public void AddBox_ShouldAddBoxToPallet()
        {
            // Arrange
            var pallet = new Pallet(1, 10, 5, 7);
            var box = new Box(1, 5, 3, 2, 1, new DateOnly(2023, 8, 17));

            // Act
            pallet.AddBox(box);

            // Assert
            Assert.AreEqual(1, pallet.Boxes.Count);
            Assert.AreEqual(box, pallet.Boxes.First());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddBox_ShouldThrowExceptionWhenBoxVolumeExceedsPalletVolume()
        {
            // Arrange
            var pallet = new Pallet(1, 10, 5, 7);
            var box = new Box(1, 15, 8, 5, 1, new DateOnly(2023, 8, 17));

            // Act
            pallet.AddBox(box);
        }
    }
}
