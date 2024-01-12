using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Item
    {
        private string _name;
        private int _price;
        public Item(string name, int price)
        {
            _name = name;
            _price = price;
        }

        public string Name { get { return _name; } }
        public int Price { get { return _price; } }
    }
}
