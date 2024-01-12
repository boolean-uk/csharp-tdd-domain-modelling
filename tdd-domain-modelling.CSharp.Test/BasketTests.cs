using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTests
    {
        [Test]
        public void AddItemToBasketTest()
        {
            //setup
            Basket basket = new Basket();

            //execute
            bool result = basket.Add("Test", 42);

            //verify
            Assert.IsTrue(result);
            Assert.That(basket.items.Count, Is.EqualTo(1));
        }

        [Test]
        public void AddingSameItemTwiceFailsTest()
        {
            //setup
            Basket basket = new Basket();

            //execute
            basket.Add("Test", 42);
            bool result = basket.Add("Test", 523);

            //verify
            Assert.IsFalse(result);
            Assert.That(basket.items.Count, Is.EqualTo(1)); //Should not add another element
            Assert.That(basket.items.First().Value, Is.EqualTo(42)); //Should not have updated element
        }

        [Test]
        public void TestTotalItemCost()
        {
            //setup
            Basket basket = new();
            basket.Add("Test", 34);
            basket.Add("Test2", 5);

            //execute
            int result = basket.TotalCost();

            //verify
            Assert.That(result, Is.EqualTo(39));
        }
    }
}