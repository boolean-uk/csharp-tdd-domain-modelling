﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main.Supermarket
{
    public class Product
    {
        private string _name;
        private decimal _price;

        public Product(string name, decimal price)
        {
            _name = name;
            _price = price;
        }
        public string Name { get { return _name; } }
        public decimal Price { get { return _price;} }
    }
}
