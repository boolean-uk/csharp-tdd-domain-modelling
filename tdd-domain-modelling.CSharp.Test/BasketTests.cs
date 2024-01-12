using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTests
    {
        [Test]
        public void AddItems()
        {
            //Set up
            Basket basket = new Basket();

            //Execute
            basket.add("Eggs", 20);
            basket.add("Spaghetti", 23);

            //Verify
            Assert.IsTrue(basket.items.Count() == 2);
        }

        [Test]
        public void AddItemsError()
        {
            //Set up
            Basket basket = new Basket();

            //Execute
            basket.add("Eggs", 20);
            basket.add("Spaghetti", 23);
            basket.add("eggs", 24);

            //Verify
            Assert.IsTrue(basket.items.Count() == 2);
            Assert.IsFalse(basket.add("Eggs", 20));
        }

        [Test]
        public void Total()
        {
            //Set up
            Basket basket = new Basket();

            //Execute
            basket.add("Eggs", 20);
            basket.add("Spaghetti", 23);
            basket.add("eggs", 24);

            //Verify
            Assert.AreEqual(43, basket.total());
        }
    }
}