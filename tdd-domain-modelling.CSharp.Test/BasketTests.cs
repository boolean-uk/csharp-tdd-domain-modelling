using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTests
{
        [Test]
        public void TestAdd() 
        {
            Basket basket = new Basket();

            string item = "milk";
            int value = 10;
            bool added = true; 

            bool result = basket.add(item, value);

            Assert.That(result == added);
        }


        [Test]
        public void TestTotal()
        {
            Basket basket = new Basket();

            string item1 = "makrell";
            string item2 = "leverpostei";
            string item3 = "ost";

            int value1 = 23;
            int value2 = 15;
            int value3 = 117;

            int expected = 155;

            basket.add(item1, value1);
            basket.add(item2, value2);  
            basket.add(item3, value3);

            int result = basket.total();

            Assert.That(result == expected);
        }
    }
}
