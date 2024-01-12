using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    internal class BasketTests
    {
        Basket basket;
        [SetUp]
        public void SetUp()
        {
            //setup
            Dictionary<string, float> items = new Dictionary<string, float>()
            {
                {"bread", 2f },
                {"honey", 4.5f },
                {"parsnip", 2.5f }
            };
            basket = new Basket(items);
        }

        [Test]
        public void AddTest()
        {


            bool result = basket.Add("peanut butter", 4f);
            Assert.IsTrue(result);
        }
        [Test]
        public void AddDuplicateTest()
        {

            bool result = basket.Add("bread", 2f);
            Assert.IsFalse(result);
        }
        [Test]
        public void AddDuplicateOtherPriceTest()
        {
            //setup
            bool result = basket.Add("honey", 4f);
            Assert.IsFalse(result);
        }

        [Test]
        public void TotalTest()
        {
            float result = basket.Total();
            Assert.That(result, Is.EqualTo(9f));
        }


    }
}
