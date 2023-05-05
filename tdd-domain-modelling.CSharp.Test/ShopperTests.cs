using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_domain_modelling.CSharp.Main;
using System.Collections.Generic;

namespace tdd_domain_modelling.CSharp.Test
{
    public class ShopperTests
    {
        Shopper _shop;
       

        public ShopperTests() { 
        
            _shop = new Shopper();

        }

        [Test]
        public void BusketCountCost() { 
            
            Assert.AreEqual(_shop.total(), 18);
            
        }

        [Test]
        public void DoesProductExistInBusket()
        {

            Assert.IsTrue(_shop.addProduct("corn" ,2));

        }

    }
}
