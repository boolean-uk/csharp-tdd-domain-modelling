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
        }

        [TestCase("Aplles2", 3, false)]
        [TestCase("Juice", 15, true)]
        [TestCase("Meat", 20, true)]
        public void addTest(string name, int value, bool expected)
        {
            Assert.IsTrue(_core.add(name, value) == expected);
        }

        [Test]
        public void totalTest()
        {
            int total = 0;
            foreach(KeyValuePair<string, int> kvp in _core.items)
            {
                total += kvp.Value;
            }
            Assert.AreEqual(_core.totalCost(), total);
        }
    }
}