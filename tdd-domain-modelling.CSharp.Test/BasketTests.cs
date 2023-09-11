using NUnit.Framework;
using tdd_domain_modelling_basket.CSharp.Main;

namespace tdd_domain_modelling_basket.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {
        [Test]
        public void AddANewProductTest()
        {
            Basket basket = new Basket();
            Assert.IsTrue(basket.add("milk", 2));
        }

        [Test]
        public void AddNewProductsTest()
        {
            Basket basket = new Basket();
            Assert.IsTrue(basket.add("milk", 2));
            Assert.IsTrue(basket.add("sugar", 1));
            Assert.IsTrue(basket.add("coffee", 4));
        }

        [Test]
        public void AddAProductTwiceTest()
        {
            Basket basket = new Basket();
            Assert.IsTrue(basket.add("milk", 2));
            Assert.IsFalse(basket.add("milk", 2));
            Assert.IsFalse(basket.add("milk", 5));
        }

        [Test]
        public void AddProductsTest()
        {
            Basket basket = new Basket();
            Assert.IsTrue(basket.add("milk", 2));
            Assert.IsFalse(basket.add("milk", 2));
            Assert.IsTrue(basket.add("sugar", 1));
            Assert.IsTrue(basket.add("coffee", 4));
            Assert.IsFalse(basket.add("milk", 3));
            Assert.IsFalse(basket.add("coffee", 5));
            Assert.IsTrue(basket.add("cookies", 2));
        }

        [Test]
        public void EmptyTotalTest()
        {
            Basket basket = new Basket();
            int result = basket.total();
            Assert.IsTrue(result == 0);
        }

        [Test]
        public void TotalShouldBe2Test()
        {
            Basket basket = new Basket();
            basket.add("milk", 2);
            int result = basket.total();
            Assert.IsTrue(result == 2);
        }

        [Test]
        public void TotalShouldBe6Test()
        {
            Basket basket = new Basket();
            basket.add("milk", 2);
            basket.add("coffee", 4);
            basket.add("milk", 2);
            int result = basket.total();
            Assert.IsTrue(result == 6);
        }
    }
}