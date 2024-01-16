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
            //Arrange
            CohortManager core = new CohortManager();

            
            string cohortSearch = "Cohort1";
            bool result = core.isInList(cohortSearch);

            Assert.IsTrue(result);
        }
    }
}