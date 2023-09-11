using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTests
    {
        [Test]
        public void AddingProduct()
        {
            //setup
            Basket basket = new Basket();
            String product = "thingie";
            int price = 1;
            int quantity = 1;
            //execute
            basket.AddProduct(product, price, quantity);
            //verify
            Receipt receipt = basket.MakeReceipt();
            Assert.IsTrue(receipt.ViewTheReceipt().Contains(product)); // expect it to be in the receipt
        }

        [Test]
        public void TotalCost()
        {
            //setup
            Basket basket = new Basket();
            basket.AddProduct("AvadakedavrO", 13, 1);
            basket.AddProduct("Harry", 12, 2);
            //execute
            int total = basket.TotalCost();
            //verify
            Assert.AreEqual(37, total); // expect it to be 37, 13+12x2
        }

        [Test]
        public void MakeReceiptBasket()
        {
            //setup
            Basket basket = new Basket();
            basket.AddProduct("Lola", 5, 1);
            basket.AddProduct("Pug", 16, 2);
            //execute
            Receipt receipt = basket.MakeReceipt();
            //verify
            string receiptContent = receipt.ViewTheReceipt();
            Assert.IsTrue(receiptContent.Contains("Lola (1): 5"));
            Assert.IsTrue(receiptContent.Contains("Pug (2): 32"));
        }

    }
}
