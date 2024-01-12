using NUnit.Framework;
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
            List<string> cohorts = new List<string>();
            
            //act
            bool result = core.search(cohorts, "Crypto");

            //assert

            Assert.IsTrue( result.GetType()==typeof(bool)) ;
        }

        [Test]
        public void SecondTest()
        {
            //arrange
            CohortManager core = new CohortManager();
            List<string> cohorts = new List<string>();

            //act
            bool result = core.search(cohorts, "Crypto");

            //assert

            Assert.IsTrue(result.GetType() == typeof(bool));
        }
    }
}