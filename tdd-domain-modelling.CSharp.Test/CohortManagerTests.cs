using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {
        [TestCase("Name1", true)]
        [TestCase("Name4", false)]
        public void FirstTest(string name, bool expectedResult)
        {
            List<string> cohorts = new List<string>();
            cohorts.Add("Name1");
            cohorts.Add("Name2");
            cohorts.Add("Name3");
            CohortManager core = new CohortManager();
            bool result = core.search(cohorts, name);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}