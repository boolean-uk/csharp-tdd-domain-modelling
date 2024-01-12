using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Product
    {
        public string _name { get; set; }
        public int _price { get; set; }
        public int _quantity { get; set; }

        public Product(string name, int price, int quantity) 
        { 
            _name = name;
            _price = price;
            _quantity = quantity;
            
        }

    }

}
