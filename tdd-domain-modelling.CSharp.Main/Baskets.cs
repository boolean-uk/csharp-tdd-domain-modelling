using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        private Dictionary<string, int> items;

        public Basket()
        {
            items = new Dictionary<string, int>();
        }

        public bool AddProduct(string productName, int price)
        {
            if (!items.ContainsKey(productName))
            {
                items[productName] = price;
                return true; // Product added successfully
            }
            else
            {
                return false; // Product already in the basket
            }
        }

        public int CalculateTotal()
        {
            int total = 0;
            foreach (var item in items)
            {
                total += item.Value;
            }
            return total;
        }
    }
}