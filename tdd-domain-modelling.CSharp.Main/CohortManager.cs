using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class CohortManager
    {
        // properties
        public List<string> Cohorts { get; set; }

        public CohortManager()
        {
            Cohorts = new List<string> {"Cohort1", "Cohort2", "Cohort3"};
        }

        public bool isInList(string name) 
        {
            return Cohorts.Contains(name);
        }
        
    }
    
}
