using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class CohortManager
    {
        public bool Search(List<string> cohorts, string nameCohort)
        {
            foreach (string cohort in cohorts) 
            {
                if (cohort.ToLower() == nameCohort.ToLower()) 
                {
                    return true;
                }
            }
            return false;
        }

    }
}
