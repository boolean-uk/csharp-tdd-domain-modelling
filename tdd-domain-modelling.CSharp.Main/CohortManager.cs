namespace tdd_domain_modelling.CSharp.Main
{
    public class CohortManager
    {
        public bool search(List<string> cohorts, string name)
        {
            return cohorts.Contains(name);
        }
    }
}
