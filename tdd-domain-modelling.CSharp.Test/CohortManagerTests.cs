using NUnit.Framework;

namespace tdd_domain_modelling.CSharp.Test
{

    [TestFixture]
    public class CohortManagerTests
    {
        private CohortManager cohortManager;
        private List<string> cohorts;

        [SetUp]
        public void SetUp()
        {
            cohortManager = new CohortManager();
            cohorts = new List<string> { "Cohort1" , "Cohort2" , "Cohort3" };
        }

        [Test]
        public void ShouldFindCohortWhenNameIsInList()
        {
            // Arrange
            string name = "Cohort1";

            // Act
            bool isFound = cohortManager.Search(cohorts , name);

            // Assert
            Assert.IsTrue(isFound);
        }

        [Test]
        public void ShouldNotFindCohortWhenNameIsNotInList()
        {
            // Arrange
            string name = "Cohort4";

            // Act
            bool isFound = cohortManager.Search(cohorts , name);

            // Assert
            Assert.IsFalse(isFound);
        }
    }
}