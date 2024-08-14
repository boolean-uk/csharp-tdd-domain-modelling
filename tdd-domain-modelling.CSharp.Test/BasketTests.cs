using NUnit.Framework;
using System.Reflection;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTests
    {
        [TestCase("Banana", 50)]
        public void AddNewItemToBasket(string productName, int productPrice)
        {
            // 1. Set up
            Basket basket = new Basket();

            // 2. Execute
            basket.Add(productName, productPrice);

            // 3. Verify
            Assert.IsTrue(basket.Items.ContainsKey(productName));

        }
        
        [Test]
        public void TryAddingExistingItemToBasket()
        {
            // 1. Set up
            Basket basket = new Basket();
            basket.Add("Banana", 50);

            // 2. Execute
            bool result = basket.Add("Banana", 50);

            // 3. Verify
            Assert.IsFalse(result);

        }

        [Test]
        public void CalculateCostOfItemsInBasket()
        {
            // 1. Set up
            Basket basket = new Basket();

            // 2. Execute
            basket.Add("Banana", 50);
            basket.Add("Pear", 40);
            basket.Add("Grape", 30);

            int result = basket.Total();

            // 3. Verify
            Assert.IsTrue(result == 120);
        }
    }
}