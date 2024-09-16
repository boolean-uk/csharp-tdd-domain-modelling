using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTests
    {
        private Basket _basket;
        [SetUp] 

        public void Setup()
        {
            // creates new basket for each test.
            _basket = new Basket();
            _basket.addItemsToBasket("Eggs", 1.5d);
            _basket.addItemsToBasket("Butter", 1.0d);
            _basket.addItemsToBasket("Tomatoes", 2.5d);
        }

        
        [Test]
        public void AddItemsToBasket() 
        {
            // execute add items to basket
            bool addedItems = _basket.addItemsToBasket("Milk", 2d);

            // check if added items ("Eggs, 1.5d) is in basket -> is true.
            Assert.That(addedItems, Is.True);
        }

        [Test]
        public void TestTotalCostsBasket()
        {
            double totalCosts = _basket.TotalCostsBasket();

            Assert.That(totalCosts, Is.EqualTo(5));
        }
    }
}