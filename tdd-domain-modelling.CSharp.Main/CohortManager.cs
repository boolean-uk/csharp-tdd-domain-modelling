using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class CohortManager
    {

    }
    public class ShoppingBasket
    {
        // declare private members
        // waarschijnlijk supermarket en de andere basket?
           private Dictionary<string, decimal> supermarket = new Dictionary<string, decimal>()
            {
                {"apple", 0.23M},
                {"banana", 0.44M},
                {"cleaner", 1.25M},
                {"pasta", 1.89M},
                {"toothpaste", 2.19M},
                {"bread", 1.30M}
            };

           private Dictionary<string, int> basket = new Dictionary<string, int>()
            {
              
            };
            // two dictonaries one as the supermarket with product as key and price as value
            // the other one as basket with product (add and substract) as key and quanity as value
       
        public void AddProduct(string product, int quantity)
        {
            if (supermarket.ContainsKey(product))
            {
                if (basket.ContainsKey(product))
                { 
                     basket[product] = basket[product] + quantity;
                }
                else
                {
                    basket.Add(product, quantity);
                }
            }
        }
        public void RemoveProduct(string product, int quantity)
        {
            if (basket.ContainsKey(product))
            {
                basket[product] = basket[product] - quantity;
                if (basket[product] <= 0)
                {
                    basket.Remove(product);
                }
            }
        }

        public decimal Total() 
        {
            decimal total = 0;
            foreach (KeyValuePair<string, int> item in basket)
            {
                total += supermarket[item.Key] * item.Value;
            }
            // quantity * price en die allemaal bij elkaar optellen
            // if basket contains supermarket, supermarket value of the keys
            // that are also in basket multiply by the value of the key in basket

            return total;
        }

        public string Receipt()
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, int> item in basket)
            {
                sb.Append(item.Key + " " );
                sb.Append(item.Value + " ");
                sb.Append(supermarket[item.Key] + " ");
                sb.Append(supermarket[item.Key] * item.Value);
            }
            return sb.ToString();
        }


        public Dictionary<string, int> Basket { get { return basket; } }
    }
}
