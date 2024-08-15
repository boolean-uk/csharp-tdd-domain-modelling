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
            CohortManager core = new CohortManager();
            List<string> cohorts = ["Ole", "Dole", "Doffen"];
            string name = "Ole";
            string name2 = "Donald";

            bool test1 = core.search(cohorts, name);
            bool test2 = core.search(cohorts, name2);

            Assert.That(test1 == true);
            Assert.That(test2 == false);
        }
    }
}