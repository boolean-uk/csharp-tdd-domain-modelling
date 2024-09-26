using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTests
    { 
        [Test]
        public void TestBasketAdd()
        {
            // Arrange
            Basket basket = new Basket();

            // Act
            basket.Add("Product1", 10);
            var receipt = basket.GenerateReceipt();

            // Assert
            Assert.AreEqual(10, receipt.TotalCost);
        }

        [Test]
        public void TestEmptyBasketReceipt()
        {
            // Arrange
            Basket basket = new Basket();

            // Act
            var receipt = basket.GenerateReceipt();

            // Assert
            Assert.IsEmpty(receipt.Items);
            Assert.AreEqual(0, receipt.TotalCost);
        }

        [Test]
        public void TestSingleProductInBasketReceipt()
        {
            // Arrange
            Basket basket = new Basket();
            basket.Add("Product1", 10);

            // Act
            var receipt = basket.GenerateReceipt();

            // Assert
            Assert.AreEqual(1, receipt.Items.Count);
            var item = receipt.Items[0];
            Assert.AreEqual("Product1", item.ProductName);
            Assert.AreEqual(1, item.Quantity);
            Assert.AreEqual(10, item.UnitPrice);
            Assert.AreEqual(10, item.TotalPrice);
            Assert.AreEqual(10, receipt.TotalCost);
        }

        [Test]
        public void TestMultipleProductsInBasketReceipt()
        {
            // Arrange
            Basket basket = new Basket();
            basket.Add("Product1", 10);
            basket.Add("Product2", 20);

            // Act
            var receipt = basket.GenerateReceipt();

            // Assert
            Assert.AreEqual(2, receipt.Items.Count);

            var item1 = receipt.Items[0];
            Assert.AreEqual("Product1", item1.ProductName);
            Assert.AreEqual(1, item1.Quantity);
            Assert.AreEqual(10, item1.UnitPrice);
            Assert.AreEqual(10, item1.TotalPrice);

            var item2 = receipt.Items[1];
            Assert.AreEqual("Product2", item2.ProductName);
            Assert.AreEqual(1, item2.Quantity);
            Assert.AreEqual(20, item2.UnitPrice);
            Assert.AreEqual(20, item2.TotalPrice);

            Assert.AreEqual(30, receipt.TotalCost);
        }

        [Test]
        public void TestEmptyReceiptTotalCost()
        {
            // Arrange
            var receipt = new Receipt { Items = new List<ReceiptItem>() };

            // Act
            int totalCost = receipt.TotalCost;

            // Assert
            Assert.AreEqual(0, totalCost);
        }

        [Test]
        public void TestSingleItemReceiptTotalCost()
        {
            // Arrange
            var receipt = new Receipt
            {
                Items = new List<ReceiptItem>
            {
                new ReceiptItem
                {
                    ProductName = "Product1",
                    Quantity = 1,
                    UnitPrice = 10
                }
            }
            };

            // Act
            int totalCost = receipt.TotalCost;

            // Assert
            Assert.AreEqual(10, totalCost);
        }

        [Test]
        public void TestMultipleItemsReceiptTotalCost()
        {
            // Arrange
            var receipt = new Receipt
            {
                Items = new List<ReceiptItem>
        {
            new ReceiptItem
            {
                ProductName = "Product1",
                Quantity = 2, // Two units of Product1
                UnitPrice = 10
            },
            new ReceiptItem
            {
                ProductName = "Product2",
                Quantity = 3, // Three units of Product2
                UnitPrice = 20
            }
        }
            };

            // Act
            int totalCost = receipt.TotalCost;

            // Assert
            // Expected total cost: (2 * 10) + (3 * 20) = 20 + 60 = 80
            Assert.AreEqual(80, totalCost);
        }
    }

}