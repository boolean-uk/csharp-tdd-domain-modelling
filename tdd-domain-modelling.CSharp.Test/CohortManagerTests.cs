using NUnit.Framework;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Resources;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {

        [Test]
        public void FirstTest()
        {
            //arrange
            CohortManager core = new CohortManager();
            decimal sum = 6 + 30 + 10;

            //act
            Dictionary<string, int> Basket = new Dictionary<string, int>()
            {
                { "soda", 2 },
                { "milk", 3 },
                { "apple", 5 }
            };
            decimal FinalSum = core.BasketSum(Basket);

            //assert
            //Assert.Fail();
            Assert.That(FinalSum, Is.EqualTo(sum));

        }

        [Test]
        public void SecondTest()
        {
            CohortManager core = new CohortManager();
            List<String> cohorts = new List<string>() { "John", "Smith", "William" };

            bool result = core.Search(cohorts, "William");

            Assert.IsTrue(result);
        }

        [Test]
        public void ThirdTest()
        {
            Basket basket = new Basket();


            bool result = basket.Add("Milk", 10);

            Assert.IsTrue(result);
        }

        [Test]
        public void FourthTest()
        {
            Basket basket = new Basket();

            basket.Items.Add("Milk", 10);
            basket.Items.Add("MoreMilk", 10);


            int result = basket.Total();
            Assert.That(result, Is.EqualTo(20));
        }
    }
}