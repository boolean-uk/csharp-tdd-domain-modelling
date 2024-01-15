using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTests
    {
        Basket basket = null;

        [SetUp]
        public void SetUp() {
            basket = new Basket();
        }

        [Test]
        public void AddItems()
        {

            basket.items.Add(new Item("Apple", 10));
            basket.items.Add(new Item("Mango", 10));

            Assert.That(basket.items.Count, Is.EqualTo(2));
            
        }

        [Test]
        public void CalculateCost() {

            basket.items.Add(new Item("Apple", 10));
            basket.items.Add(new Item("Orange", 22));

            Assert.That(basket.calculateCost(), Is.EqualTo(32));
        }

    }
}