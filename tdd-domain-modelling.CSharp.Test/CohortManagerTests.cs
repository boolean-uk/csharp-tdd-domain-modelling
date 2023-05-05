using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    public class CohortManagerTest
    {
        private CohortManager _core;

        public CohortManagerTest()
        {
            _core = new CohortManager();
            

        }
        [Test]
        public void CohortTest()
        {
            List<string> list = new List<string>
            {
                "Lisa",
            };

            Assert.IsTrue(_core.search(list, "Lisa"));
            Assert.IsFalse(_core.search(list, "Joop"));
        }
    }
}