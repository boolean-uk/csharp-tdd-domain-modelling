using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
 {   
    //[TestFixture]
    public class BasketTests
    {
        [Test]
        
        public void AddsProductsToBasket()
        {
            //RED
            // Should Add products to the basket
            //1. Setup
            Basket basket = new Basket();

            //2. Execute
            bool result = basket.Add("Milk", 2);

            //3. Verify
            Assert.That(result, Is.True);
           
        }
        [Test]
        public void TotalCostOfItems()
        {
            //Should calculate the total cost of items from the shoppingchart.
            //1. Setup
            Basket basket = new Basket();
            basket.Add("Milk", 2);
            basket.Add("Bread", 4);

            //2. Execute
            int totalCost = basket.Total();

            //3. Verify
            Assert.That(totalCost, Is.EqualTo(6));

        }





    }


    
}

