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
            //execute
            basket.addProduct(product, price, quantity);
            //verify
            Receipt receipt = basket.makeReceipt();
            Assert.IsTrue(receipt.viewTheReceipt.Contains(product)); // expect it to be in the receipt
        }

        [Test]
        public void TotalCost()
        {
            //setup
            Basket basket = new Basket();
            basket.addProduct("AvadakedavrO", 13, 1);
            basket.addProduct("Harry", 12, 2);
            //execute
            int total = basket.totalCost();
            //verify
            Assert.AreEqual(37, total); // expect it to be 37, 13+12x2
        }

        [Test]
        public void MakeReceiptBasket()
        {
            //setup
            Basket basket = new Basket();
            basket.addProduct("Lola", 5, 1);
            basket.addProduct("Pug", 16, 2);
            //execute
            Receipt receipt = basket.makeReceipt();
            //verify
            string receiptContent = receipt.viewTheReceipt();
            Assert.IsTrue(receiptContent.Contains("Lola (1): 5"));
            Assert.IsTrue(receiptContent.Contains("Pug (2): 32"));
        }

    }
}
