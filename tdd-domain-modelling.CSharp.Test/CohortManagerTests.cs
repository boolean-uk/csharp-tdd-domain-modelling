using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {
        [Test]

        [TestCase("Marcus", true)]
        [TestCase("Victor", true)]
        [TestCase("Carlo", false)]
        public void FirstTest(string testName, bool ExpectedResult)
        {
            CohortManager core = new CohortManager();
            
            List<string> TestStrings;
            TestStrings = new List<string>() {"Marcus", "Victor", "Adam", "Pontus", "Oliver"};

            bool result = core.search(TestStrings,testName);
            Assert.That(result, Is.EqualTo(ExpectedResult));
        }
    }
}