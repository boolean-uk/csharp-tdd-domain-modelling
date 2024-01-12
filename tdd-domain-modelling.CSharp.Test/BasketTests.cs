using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTests
    {
        Basket basket;

        [SetUp]
        public void SetUp()
        {
            basket = new Basket();
        }

        [Test]
        public void AddingItemsToBasket()
        {
            bool result = basket.add("Cheese", 30);
            bool result2 = basket.add("Ham", 40);

            Assert.IsTrue(result2);
        }

        [Test]
        public void AddingDoubleItemsToBasket()
        {
            bool result = basket.add("Cheese", 30);
            bool result2 = basket.add("Cheese", 40);

            Assert.IsFalse(result2);
        }

        [Test]
        public void TestingTotalValue()
        {
            basket.add("Ham", 40);
            basket.add("Cheese", 30);
            basket.add("Milk", 50);
            int totalCost = basket.total();

            Assert.That(120, Is.EqualTo(totalCost));
        }

        [Test]
        public void TestingTotalDoubles()
        {
            basket.add("Ham", 40);
            basket.add("Ham", 30);
            basket.add("Milk", 50);
            int totalCost = basket.total();

            Assert.That(90, Is.EqualTo(totalCost));
        }
    }
}