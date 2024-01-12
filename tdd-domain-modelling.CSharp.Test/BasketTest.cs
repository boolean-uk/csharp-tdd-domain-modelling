using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;
using System.Xml.Linq;

namespace tdd_domain_modelling.CSharp.Test
{
    public class BasketTest
    {
        [Test]
        public void ShouldNotBeEmpty()
        {
            // 1. Set up
            Basket basket = new Basket();

            // 2. Execute
            basket.Add("Milk", 5);

            // 3. Verify
            Assert.That(basket.Items.Count > 0);
        }

        [Test]
        public void ShouldReturnTrue()
        {
            // 1. Set up
            Basket basket = new Basket();

            // 2. Execute
            Boolean added = basket.Add("Milk", 5);

            // 3. Verify
            Assert.That(added);
        }

        [Test]
        public void ShouldReturnFalse()
        {
            // 1. Set up
            Basket basket = new Basket();

            // 2. Execute
            basket.Add("Milk", 5);
            Boolean added = basket.Add("Milk", 5);

            // 3. Verify
            Assert.That(!added);
        }

        [Test]
        public void ShouldReturnTotal()
        {
            // 1. Set up
            Basket basket = new Basket();

            // 2. Execute
            basket.Add("Milk", 5);
            basket.Add("Sugar", 7);
            basket.Add("Egg", 4);

            // 3. Verify
            Assert.That(basket.Total() == 16);
        }
        [Test]
        public void ShouldReturnTotalDuplicate()
        {
            // 1. Set up
            Basket basket = new Basket();

            // 2.
            basket.Add("Sugar", 7);
            basket.Add("Milk", 5);
            basket.Add("Milk", 5);
            basket.Add("Sugar", 7);
            basket.Add("Egg", 4);

            // 3. Verify
            Assert.That(basket.Total() == 28);
        }

    }
}
