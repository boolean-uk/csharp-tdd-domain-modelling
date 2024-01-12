using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        private Dictionary<string, float> items = new Dictionary<string, float>(){
            {"Apple", 1f},
            {"Orange", 2f},
            {"Banana", 3f},
            {"Milk", 4f},
            {"Bread", 5f}
        };

        public float GetPrice(string item)
        {
            if (items.ContainsKey(item) == false)
            {
                return 0f;
            }
            return items[item];
        }

        public Dictionary<string, int> itemsInBasket = new Dictionary<string, int>();

        public void AddItem(string item, int quantity)
        {
            if (itemsInBasket.ContainsKey(item))
            {
                itemsInBasket[item] += quantity;
            }
            else if (items.ContainsKey(item) == false)
            {
                itemsInBasket.Add(item, 0);                
            }
            else
            {
                itemsInBasket.Add(item, quantity);
            }
        }

        public void RemoveItem(string item, int quantity)
        {
            if (itemsInBasket.ContainsKey(item))
            {
                itemsInBasket[item] -= quantity;
            }
            else
            {
                itemsInBasket.Add(item, 0);
            }
        }

        public float GetTotalCost()
        {
            float total = 0;
            foreach (KeyValuePair<string, int> item in itemsInBasket)
            {
                total += items[item.Key] * item.Value;
            }
            return total;
        }
    }
}


