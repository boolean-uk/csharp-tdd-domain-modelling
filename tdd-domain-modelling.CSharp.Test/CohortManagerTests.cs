using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {
        [Test]
        public void searchReturnsTrueIfFound()
        {
            CohortManager core = new CohortManager();

            List<string> list = new List<string>()
            { "Kyle", "Jim", "Daniel" };


            Assert.AreEqual(true, core.search(list, "Kyle"));
            Assert.AreEqual(true, core.search(list, "Jim"));
            Assert.AreEqual(true, core.search(list, "Daniel"));
        }
        [Test]
        public void searchReturnsFalseIfNotFound()
        {
            CohortManager core = new CohortManager();

            List<string> list = new List<string>()
            { "Kyle", "Jim", "Daniel" };

            Assert.AreEqual(false, core.search(list, "Jerry"));
            Assert.AreEqual(false, core.search(list, "Donald"));
        }
    }
}