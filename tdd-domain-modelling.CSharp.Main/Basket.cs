using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{

    public struct Item
    {
        public string itemName { get; set; }
        public int itemPrice { get; set; }

        public Item(string name, int price)
        {
            itemName = name;
            itemPrice = price;
        }
    }
    public class Basket
    {

        public List<Item> Items { get; set; }

        public Basket()
        {
            Items = new List<Item>();
        }


        public bool addItem(string item, int price)
        {
            bool result;
            Item temp = new Item(item,price);

            if (Items.Contains(temp) == true)
            {
                result = false;
            }
            else
            {
                Items.Add(temp);
                result = true;
            }

            return result;
        }
        public int totalCost()
        {
            int total = 0;

            foreach (Item item in Items)
            {
                total += item.itemPrice;
            }


            return total;
        }


    }
}
