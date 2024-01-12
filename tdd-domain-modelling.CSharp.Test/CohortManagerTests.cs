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

            List<string> cohorts = new List<string> { "A", "B", "C" };

            string name1 = "A";
            string name2 = "D";

            bool res1 = core.search(cohorts, name1);

            Assert.That(res1, Is.True);

            bool res2 = core.search(cohorts, name2);

            Assert.That(res2, Is.False);
        }
    }
}