using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {
        CohortManager core;
        [SetUp]
        public void SetUp()
        {
             core = new CohortManager();
        }
        [Test]
        public void FirstTest()
        {
            List<string> list = new List<string>()
            {
                "Hallo",
                "Wereld",
                "De",
                "Wereld",
                "Is",
                "Van",
                "Mij"
            };
            bool result = core.Search(list, "Wereld");
            Assert.IsTrue(result);
        }
        [Test]
        public void SecondTest()
        {
            List<string> list = new List<string>()
            {
                "Hallo",
                "Wereld",
                "De",
                "Wereld",
                "Is",
                "Van",
                "Mij"
            };
            bool result = core.Search(list, "Óranje");
            Assert.IsFalse(result);
        }
        [Test]
        public void EmptyTest()
        {
            bool result = core.Search(new List<string>(), "Blue");
            Assert.IsFalse(result);
        }


    }
}