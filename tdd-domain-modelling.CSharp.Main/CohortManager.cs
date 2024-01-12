using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class CohortManager
    {
        // public List<string> _cohorts = new List<string>{ "Cohort1", "Cohort2", "Cohort3"};

        public CohortManager() 
        { 
        }

        public bool search(List<string> ch, String name)
        {
            if (ch.Contains(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
