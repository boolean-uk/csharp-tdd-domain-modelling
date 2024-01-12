using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {
        [Test]
        public void TestSearch()
        {
            CohortManager core = new CohortManager();
            List<string> classes = new List<string>() {"Java", "C#", "Python"};
            string name = "Python";
            
            bool exists = core.search(classes, name);
            
            Assert.IsTrue(exists);
        }

        [Test]
        public void TestBasketAdd()
        {
            Basket basket = new Basket();
            string product = "Milk";
            int price = 100;

            bool truthValue = basket.Add(product, price);

            Assert.IsTrue(truthValue);

        }
        [Test]
        public void TestBasketAdd2() 
        {  
            Basket basket = new Basket();
            string product = "Milk";
            string duplicate = "Milk";
            int price = 199;

            basket.Add(product, price);
            bool falseValue = basket.Add(duplicate, price);

            Assert.IsFalse(falseValue);
        }


        [Test]
        public void TestBasketTotal1()
        {
            Basket basket = new Basket();
            
            basket.Add("Celery", 40);
            basket.Add("Butter", 50);
            basket.Add("Green beans", 30);
            basket.Add("Butter beans", 60);

            int total = basket.total();

            Assert.AreEqual(total, 180);
        }
        [Test]
        public void TestBasketTotal2()
        {
            Basket basket = new Basket();

            basket.Add("Celery", 10);
            basket.Add("Bean", -2);
            basket.Add("Green", 30);

            int total = basket.total();

            Assert.AreEqual(total, 40);
        }
    }
}