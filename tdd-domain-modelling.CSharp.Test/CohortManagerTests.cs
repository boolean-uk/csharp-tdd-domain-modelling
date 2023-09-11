using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {
        [Test]
        public void AddingProduct()
        {
            //setup
            CohortManager.Basket basket = new CohortManager.Basket();
            String product = "Apple";
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
            CohortManager.Basket basket = new CohortManager.Basket();
            basket.addProduct("AvadakedavrO", 13);
            basket.addProduct("Harry", 12);
            //execute
            int total = basket.totalCost();
            //verify
            Assert.AreEqual(25, total); // expect it to be 25
        }

        [Test]
        public void Receipt()
        {
            //setup
            CohortManager.Receipt receipt = new CohortManager.Receipt();
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