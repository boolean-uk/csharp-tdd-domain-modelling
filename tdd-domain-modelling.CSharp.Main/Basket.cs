﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        Dictionary<string, int> items = new Dictionary<string, int>();

        public bool add(string product, int price) 
        {
            return items.TryAdd(product, price);
        }

        public int total()
        {
            return items.Sum(item => item.Value);
        }
    }
};
