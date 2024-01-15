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

            List<string> list = new List<string>()
            {
                "Jacob",
                "Pia",
                "Nikolaj"
            };

            bool testResult = core.search(list, "Jacob");
            Assert.IsTrue(testResult);
        }
        [Test]
        public void SecondTest()
        {
            CohortManager core = new CohortManager();

            List<string> list = new List<string>()
            {
                "Jacob",
                "Pia",
                "Nikolaj"
            };

            bool testResult = core.search(list, "Klaus");
            Assert.IsFalse(testResult);
        }
    }
}