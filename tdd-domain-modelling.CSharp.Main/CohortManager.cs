public class CohortManager
{
    public bool Search(List<string> cohorts , string name)
    {
        return cohorts.Contains(name);
    }
}
