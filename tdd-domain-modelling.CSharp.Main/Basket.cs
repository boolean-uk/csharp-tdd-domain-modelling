using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        private Dictionary<string, int> Items;

        public Basket()
        {
            Items = new Dictionary<string, int>();
        }

        public bool add(string item, int price)
        {
            // Check if the item is already in the basket
            if (Items.ContainsKey(item))
            {
                Items[item] += price;
                return false;
            }

            // Add the item to the basket
            Items.Add(item, price);
            return true;
        }


        public int total()
        {
            int totalValue = Items.Values.Sum();
            return totalValue;
        }

        public void clear()
        {
            Items.Clear();
        }

        public void remove(string item)
        {
            Items.Remove(item);
        }
    }
}