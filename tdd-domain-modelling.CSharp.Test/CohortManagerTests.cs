using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {
        private CohortManager _manager;
        private List<string> _cohort;

        [SetUp]

        public void SetUp()
        {
            _manager = new CohortManager();
            _cohort = new List<string>();
            _cohort.Add("Kindergarden");
            _cohort.Add("Cohort");
            _cohort.Add("Cohort 3");
            _cohort.Add("Cohort 4");
        }


        [TestCase("Kindergarden", true)]
        [TestCase("cohort", true)]
        [TestCase("Cohort 5", false)]
        [TestCase("", false)]

        public void FirstTest(string nameCohort, bool result)
        {
            bool actualResult = _manager.Search(_cohort, nameCohort);
            Assert.That(actualResult, Is.EqualTo(result));
        }
    }
}