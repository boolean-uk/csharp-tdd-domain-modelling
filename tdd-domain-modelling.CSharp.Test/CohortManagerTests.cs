using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    public class CohortManagerTest
    {
        private CohortManager _core;
        List<string> listofcohorts = new List<string>();
        public CohortManagerTest()
        {
            _core = new CohortManager();
            listofcohorts.Add("Thanasis");
            listofcohorts.Add("Test");
            listofcohorts.Add("Nigel");


        }

        [TestCase("thanasis")]
        [TestCase("nigel")]


        public void ShouldContainCohort(string b)
        {
            Assert.IsTrue(_core.search(listofcohorts, b));
        }
    }
}