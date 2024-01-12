using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTest
    {
        //input ("apple", 19) ==> out should be true
        [Test]
        public void FirstTest()
        {
            Basket basket = new Basket();

            bool result = basket.Add("apple", 19);
            Assert.IsTrue(result);
        }

        //input ("apple", 19), ("apple", 19) ==> out should be false
        [Test]
        public void SecondTest()
        {
            Basket basket = new Basket();
            basket.Add("apple", 19);
            bool result = basket.Add("apple", 19);
            
            Assert.IsFalse(result);
        }

         //input ("apple", 19), ("pear", 21) ==> out should be 40
        [Test]
        public void ThirdTest()
        {
            Basket basket = new Basket();
            basket.Add("apple", 19);
            basket.Add("pear", 21);
            int total = basket.Total();
            
            Assert.AreEqual(40, total);
        }
    }
}