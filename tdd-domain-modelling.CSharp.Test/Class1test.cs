using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class Class1test
    {

        public void AddToCart()
        { 
        Product chicken = new Product("Chicken", 69.99);
        Product milk = new Product("Milk", 29.99);

        ShoppingCart cart = new ShoppingCart();



            cart.Add(milk);
            cart.Add(chicken);

            Assert.AreEqual(2, cart.CalculateTotal()); 
        }
        [Test]
        public void CalculateTotal()
        {
            Product chicken = new Product("Chicken", 69.99);
            Product milk = new Product("Milk", 29.99);

            ShoppingCart cart = new ShoppingCart();



            cart.Add(milk);
            cart.Add(chicken); ;

           
            double total = cart.CalculateTotal();
            Assert.AreEqual(99,98, total);

          
        }



    }



}
