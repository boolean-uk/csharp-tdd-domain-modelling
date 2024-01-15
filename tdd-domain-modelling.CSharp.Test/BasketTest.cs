using Main;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestFixture]
    public class BasketTest
{
        [TestCase("Banana", 2)]
        public void AddItemTest(string product, int price)
        {
            //arrange
            Basket basket = new Basket();

            //act
            basket.AddItem(product, price);

            //assert         
            Assert.AreEqual(basket.Items.Count, 1);
            

        }

        [TestCase()]
        public void TotalBasketCostTest()
        {
            //arrange
            Basket basket = new Basket();


            basket.AddItem("Banana", 2);
            basket.AddItem("Apple", 3);
            basket.AddItem("Coca cola", 6);

           
            //act
            int totalcost = basket.TotalBasketCost();

            //assert
            Assert.IsTrue(totalcost == 11);

        }
}
}
