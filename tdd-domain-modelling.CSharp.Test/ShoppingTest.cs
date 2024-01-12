using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class ShoppingTest
    {


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
            Item item = new Item("produkt1", 15);
            Item item2 = new Item("produkt2", 5);
            Item item3 = new Item("produkt3", 25);
            Basket2 basket2 = new Basket2();
            Dictionary<Item, int> items = new Dictionary<Item, int>()
            {
                { item, 2}, {item2, 1}, {item3, 3 }
            };
            basket2.basket = items;
            
            List<string> reccipt = basket2.GetReceipt();
            Assert.That(reccipt, Is.EqualTo(new List<string> { "produkt1 x2 :30", "produkt2 x1 :5", "produkt3 x3 :75", "Total cost: 110" }));
            
            

        }
    }
}