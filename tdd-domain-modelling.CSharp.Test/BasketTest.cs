using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {
        private Basket basket;

        [SetUp]
        public void SetUp()
        {
            basket = new Basket();
        }

        [Test]
        public void AddProduct()
        {
            string product = "Apple";
            int price = 1;
            bool isAdded = basket.Add(product , price);
            Assert.IsTrue(isAdded);
            Assert.IsTrue(basket.items.ContainsKey(product));
            Assert.AreEqual(price , basket.items[product]);
        }

        [Test]
        public void NotAddDuplicateProduct()
        {
            string product = "someProduct";
            int price = 1;
            basket.Add(product , price);
            bool isAdded = basket.Add(product , price);
            Assert.IsFalse(isAdded);
        }

        [Test]
        public void CalculateTotal()
        {
            basket.Add("someProduct" , 1);
            basket.Add("someProduct1" , 2);
            int total = basket.Total();
            Assert.AreEqual(3 , total);
        }

        [Test]
        public void FirstTest()
        {
            Basket core = new Basket();
        }
    }
}