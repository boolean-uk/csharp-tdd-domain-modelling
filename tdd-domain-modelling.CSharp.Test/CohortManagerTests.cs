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
            basket.addProduct(product, price);
            //verify
            Assert.IsTrue(basket.products.ContainsKey(product)); // expect it to be true
        }
        [Test]
        public void TotalCost()
        {
            //setup
            Basket basket = new Basket();
            basket.addProduct("AvadakedavrO", 13);
            basket.addProduct("Harry", 12);
            //execute
            int total = basket.totalCost();
            //verify
            Assert.AreEqual(25, total); // expect it to be 25
        }
        [Test]
        public void MakeReceiptBasket()
        {
            //setup
            Basket basket = new Basket();
            basket.addProduct("Lola", 5);
            basket.addProduct("Pug", 16);
            //execute
            Receipt receipt = basket.makeReceipt();
            //verify
            Assert.AreEqual(2, receipt.purchasedProducts.Count);
            Assert.IsTrue(receipt.purchasedProducts.ContainsKey("Lola"));
            Assert.IsTrue(receipt.purchasedProducts.ContainsKey("Pug"));

        }
    }

    [TestFixture]
    public class ReceiptTests
    {

        [Test]
        public void Receipt()
        {
            //setup
            Receipt receipt = new Receipt();
            receipt.purchasedProducts.Add("Lord", 11);
            receipt.purchasedProducts.Add("Voldemort", 14);
            //execute
            String theReceipt = receipt.viewTheReceipt();
            //verify
            String expectedReceipt = "Lord : 11,Voldemort : 14";
            Assert.AreEqual(expectedReceipt, theReceipt); // expect it to be Lord: 11,Voldemort: 14

        }
    }
}