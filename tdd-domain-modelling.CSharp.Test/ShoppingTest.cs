using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Diagnostics.CodeAnalysis;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class ShoppingTest
    {
        public ShopingBasket basket;
        public store store;

        [SetUp]
        public void SetUP()
        {
            basket = new ShopingBasket();
            basket.basket.Clear();
            store = new store();
        }

        [Test]

        [TestCase(65)]
        public void FirstTest(int expectedCost)
        {
            Basket basket = new Basket();

            basket.basket = new Dictionary<string, int>()
            {
                {"milk", 30}, {"eggs", 15}, {"sugar", 20}
            };
            int cost;
            cost = basket.TotalCost();




            Assert.That(cost, Is.EqualTo(expectedCost));
        }


        [TestCase(0)]
        public void SecondTest(int expectedCost)
        {
            Basket basket = new Basket();

            basket.basket = new Dictionary<string, int>();
            int cost;
            cost = basket.TotalCost();




            Assert.That(cost, Is.EqualTo(expectedCost));
        }


        /*------------------------------------------------------------------------------------------*/

        [Test]

        public void ThirdTest()
        {
            Item item = new Item("produkt1", 15, 1);
            Item item2 = new Item("produkt2", 5, 2);
            Item item3 = new Item("produkt3", 25, 3);
            Basket2 basket2 = new Basket2();
            Dictionary<Item, int> items = new Dictionary<Item, int>()
            {
                { item, 2}, {item2, 1}, {item3, 3 }
            };
            basket2.basket = items;

            List<string> reccipt = basket2.GetReceipt();
            Assert.That(reccipt, Is.EqualTo(new List<string> { "produkt1 x2 :30", "produkt2 x1 :5", "produkt3 x3 :75", "Total cost: 110" }));



        }

        //new tests for exercise 2

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void Test1(int testItemID)
        {
            string teststring = basket.AddItemToShopingBasket(testItemID);

            Assert.That(teststring, Is.EqualTo($"{store.stock[testItemID].Name} was added to the basket"));
        }

        [Test, TestCase(0)]
        public void Test2(int testItemID)
        {
            string teststring = basket.AddItemToShopingBasket(testItemID);

            Assert.That(teststring, Is.EqualTo("not a valid id"));
        }

        
    
    
    


        [Test]
        
        public void Test3()
        {
            List<int> ids = new List<int>() { 1, 3 };

            int testCost = 0;
            foreach ( int id in ids )
            {
                basket.AddItemToShopingBasket(id);
                testCost = testCost + store.stock[id].Price;
            }

            string testString = basket.GetCostFromBasket();

            Assert.That(testString, Is.EqualTo($"the total cost of all: {basket.basket.Count} items is: {testCost}"));
        }
    }
}