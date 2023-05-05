using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {

        private Dictionary<string, int> _products = new Dictionary<string, int>()
        {
            {"Fish", 10}
        };

        public bool AddProduct(string name, int price)
        {
            if(!_products.ContainsKey(name))
            {
                _products.Add(name, price);
                return true;
            }
            return false;
        }

        public int Total()
        {
            int totalCost = 0;
            foreach (KeyValuePair<string, int> kvp in _products)
            {
                totalCost += kvp.Value;
            }
            return totalCost;
        }

        public void Receipt()
        {
            int totalCost = 0;
            foreach (KeyValuePair<string, int> kvp in _products)
            {
                Console.WriteLine($"Item: {kvp.Key} Price: {kvp.Value}");
                totalCost += kvp.Value;
            }
            Console.WriteLine($"The quantity of the products that you bought is: {_products.Count} and the total cost of your basket is: {totalCost}");
        }
    }
}
