using Microsoft.VisualStudio.TestTools.UnitTesting;
using PACM.BL;

namespace PACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTests
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            var productRepository = new ProductRepository();

            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                Description = "Assorted size set of 4 bright yellow mini sunflowers",
                Name = "Sunflowers"
            };

            // Act
            var actual = productRepository.Retrieve(2);

            // Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.Name, actual.Name);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            // Arrange
            var productRepository = new ProductRepository();

            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                Description = "Assorted size set of 4 bright yellow mini sunflowers",
                Name = "Sunflowers",
                HasChanges = true
            };

            // Act
            var actual = productRepository.Save(updatedProduct);

            // Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            // Arrange
            var productRepository = new ProductRepository();

            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                Description = "Assorted size set of 4 bright yellow mini sunflowers",
                Name = "Sunflowers",
                HasChanges = true
            };

            // Act
            var actual = productRepository.Save(updatedProduct);

            // Assert
            Assert.AreEqual(false, actual);
        }
    }
}
