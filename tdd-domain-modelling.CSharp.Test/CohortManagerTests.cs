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
            
            List<string> strings = new List<string>();

            strings.Add("a");
            strings.Add("b");
            strings.Add("c");

            bool res = core.search(strings, "a");

            Assert.IsTrue(res);
            
            

        }
        [Test]
        public void SecondTest()
        {
            CohortManager core = new CohortManager();

            List<string> strings = new List<string>();

            strings.Add("a");
            strings.Add("b");
            strings.Add("c");

            bool res = core.search(strings, "d");

            Assert.IsFalse(res);



        }


    }
}