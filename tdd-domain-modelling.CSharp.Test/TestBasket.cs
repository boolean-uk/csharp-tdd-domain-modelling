using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    public class TestBasket
{
        [Test]
        public void testAdd()
        {
            // Arrange
            Basket basket = new Basket();
        
            // Act:
            (string, int) item = ("Cola",10 );
            basket.Add(item.Item1, item.Item2);
            var items = basket.getItems();

            // Assert:
            Assert.IsTrue(basket.getItems().ContainsKey(item.Item1) == true && basket.getPrice(item.Item1) == item.Item2);
        
        }

        [Test]
        public void testTotalPrice()
        {
            // Arrange
            Basket basket = new Basket();

            // Act:
            (string, int) item1 = ("Cola", 10);
            (string, int) item2 =  ("Pepsii", 5);
            (string, int) item3= ("Cola", 10);
            //(string, int) item3 = ("ColaC", 2);
            basket.Add(item1.Item1, item1.Item2);
            basket.Add(item2.Item1, item2.Item2);
            basket.Add(item3.Item1, item3.Item2);
            
            var items = basket.getItems();
            //int totalP = basket.getTotalPrice();

            // Assert:
            Assert.IsTrue(basket.getTotalPrice() == 25);

        }

        [Test]
        public void testgetQTY()
        {
            // Arrange
            Basket basket = new Basket();

            // Act:
            (string, int) item1 = ("Cola", 10);
            (string, int) item2 = ("Pepsii", 5);
            (string, int) item3 = ("Cola", 10);
            //(string, int) item3 = ("ColaC", 2);
            basket.Add(item1.Item1, item1.Item2);
            basket.Add(item2.Item1, item2.Item2);
            basket.Add(item3.Item1, item3.Item2);

            var items = basket.getItems();
            //int totalP = basket.getTotalPrice();

            // Assert:
            Assert.IsTrue(basket.getQty("Cola") == 2);
            Assert.IsTrue(basket.getQty("Pepsii") == 1);

        }

       /* [Test]
        public void testgetReciept()
        {
            // Arrange
            Basket basket = new Basket();

            // Act:
            (string, int) item = ("Cola", 10);
            (string, int) item2 = ("Cola", 10);
            (string, int) item3 = ("Pepsii", 5);
            basket.Add(item.Item1, item.Item2);
            basket.Add(item2.Item1, item2.Item2);
            basket.Add(item3.Item1, item3.Item2);

            List<(string, int, int)> tempList = new List<(string, int, int)>
            {
                ( "Cola",2,10 ),
                ("Pepsii", 1, 5)
            };
            (List<(string, int, int)>, int) check = basket.getReceipt();
           // (List<(string, int, int)>, int) checkList = 
            //int totalP = basket.getTotalPrice();

            // Assert:
            Assert.IsTrue(check == (tempList,25));
           

        }*/



    }
}
