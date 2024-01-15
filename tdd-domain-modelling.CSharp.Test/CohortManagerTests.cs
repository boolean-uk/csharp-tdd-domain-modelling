using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {

        [Test]
        public void Exists()
        {
            CohortManager manager = new CohortManager();

            List<string> cohorts = new List<string>();

            cohorts.Add("Test 1");
            cohorts.Add("Test 2");
            cohorts.Add("Test 3");

            Assert.That(manager.Search(cohorts, "Test 2"), Is.EqualTo(true));
        }

        [TestCase ("4", false)]
        [TestCase ("5", false)]
        [TestCase ("6", false)]
        [TestCase ("7", false)]
        public void IfNotExists(string name, bool expected)
        {
            CohortManager manager = new CohortManager();

            List<string> cohorts = new List<string>();

            cohorts.Add("1");
            cohorts.Add("2");
            cohorts.Add("3");

            Assert.That(manager.Search(cohorts, name), Is.EqualTo(expected));
        }

    }
}