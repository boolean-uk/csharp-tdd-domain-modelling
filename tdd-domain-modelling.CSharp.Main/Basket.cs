using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    //public class Store
    //{
    //    private Dictionary<string, int> _products = new Dictionary<string, int>();
    //    public Dictionary<string, int> Products { get { return _products; } set { _products = value; } }

    //    public Store()
    //    { 
    //        for (int i = 0; i < 10; i++)
    //        {
    //            Products.Add($"Product {i}", i);
    //        }
    //    }
    //}


    public class Basket
    {
        private Dictionary<string, int> _products = new Dictionary<string, int>();
        public Dictionary<string, int> Products { get { return _products; } set { _products = value; } }


        public bool add(string productName, int price)
        {
            if (Products.Keys.Contains(productName))
            {
                return false;
            }
            else
            {
                Products.Add(productName, price);
                return true;
            }

        }



        public int basketTotal()
        {
            int total = 0;
            foreach (var product in Products)
            {
                total += product.Value;
            }
            return total;
        }
    }
}
