using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class CohortManager
    {
        public CohortManager() {

         
        
        }
        public bool search(List<string> cohorts, string name)
        {
            bool result;
            for(int i = 0; i < cohorts.Count; i++)
            {
                cohorts[i] = cohorts[i].ToUpper();
            }
            
                if (cohorts.Contains(name.ToUpper()))
                {
                    result= true;
                    
                }
                else
                {
                    result = false;

                }
            
           return result;
        }
    }
}
