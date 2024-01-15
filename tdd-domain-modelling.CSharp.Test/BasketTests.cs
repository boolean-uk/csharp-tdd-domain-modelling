using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTests
    {

        Basket basket;

        public BasketTests()
        {
            this.basket = new Basket();
        }

        [Test]
        public void AddTest()
            {
            //arrange
            Basket _basket = new Basket();
            Dictionary<string, int> basket = new Dictionary<string, int>();
            basket.Add("Milk", 35);
            basket.Add("Eggs", 40);
            basket.Add("Bread", 30);
            //act
            basket.Add("Butter", 50);
            //assert
            Assert.IsTrue(4 == basket.Count);
            }

        [Test]
        public void TotalTest()
        {
            //arrange
            Basket basket = new Basket();
            Dictionary<string, List<int>> testBasket = new Dictionary<string, List<int>>();
            int testTotal = 0;

            //act
            testBasket.Add("Milk", [35,2]);
            testBasket.Add("Eggs", [40, 2]);
            foreach (KeyValuePair<string, List<int>> kvp in testBasket)
            {
                string product = kvp.Key;
                List<int> priceQt = kvp.Value;

                testTotal = testTotal + (priceQt[0] * priceQt[1]);
            }
            //assert
            Assert.IsTrue(basket.Total() == testTotal);

        }
    }
}
