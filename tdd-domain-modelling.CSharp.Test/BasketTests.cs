using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTest
    {
        [Test]
        public void AddOneItemTest()
        {
            Basket basket = new Basket();
            bool added = basket.add("apple");

            Assert.IsTrue(added);
        }

        [Test]
        public void AddTwoItemTest()
        {
            Basket basket = new Basket();
            bool added = basket.add("apple");
            added = basket.add("milk");

            Assert.IsTrue(added);
        }

        [Test]
        public void AddDuplicateItemTest()
        {
            Basket basket = new Basket();
            bool added = basket.add("apple");
            added = basket.add("apple");

            Assert.IsTrue(!added);
        }

        [Test]
        public void CheckTotalCostTest()
        {
            Basket basket = new Basket();
            bool added = basket.add("apple");
            added = basket.add("milk");
            added = basket.add("steak");

            Assert.IsTrue(added);
            Assert.That(basket.total() == 35);
        }
    }
}