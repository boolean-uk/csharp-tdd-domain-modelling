﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class CohortManager
    {
        public bool search(List<String> cohorts, String name)
        {
           
            return cohorts.Contains(name);
        }
    }
}