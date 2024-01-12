using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {
        CohortManager manager;

        [SetUp] public void SetUp()
        {
            manager = new CohortManager();
        }

        [TestCase("Klara", true)]
        [TestCase("Emelie", false)]
        [TestCase("Elsa", true)]
        [TestCase("Klaras", false)]
        public void FindCohortByName(string findName, bool expectedResult)
        {
            List<string> cohorts = new List<string>();
            cohorts.Add("Klara");
            cohorts.Add("Arvid");
            cohorts.Add("Erik");
            cohorts.Add("Elsa");

            bool foundName = manager.Search(cohorts, findName);
            Assert.That(foundName, Is.EqualTo(expectedResult));
        }
    }
}