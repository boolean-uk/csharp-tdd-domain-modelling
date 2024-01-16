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
    public class BasketTest
    {
        [Test]

        public void firstBasketTest()
        {
            Basket core = new Basket();

            core.addToBasket("Cola", 2);
            core.addToBasket("Pepsimax", 3);
            core.addToBasket("Fanta", 8);

            string[] expectedArray = { "Cola", "Pepsimax", "Fanta" };
            
            string[] actualArray = core.Items.Keys.ToArray();

            Assert.AreEqual(expectedArray, actualArray);

            Assert.AreEqual(core.total(), 13);

        }
    }
}
