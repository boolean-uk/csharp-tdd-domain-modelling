using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class CohortManager
    {
        public bool Search(List<string> cohorts, string name)
        {
            for (int i = 0; i < cohorts.Count(); i++)
            {
                if (cohorts[i] == name)
                    return true;
            }

            return false;
        }
    }
}
