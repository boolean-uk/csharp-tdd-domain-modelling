using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Shopping
    {



    }
    public class Basket
    {
        public Dictionary<string, int> basket { get; set; }


        public int TotalCost()
        {
            int cost = 0;
            foreach (var item in basket)
            {
                cost = cost + item.Value;
            }
            return cost;
        }

    }


    public class Item
    {
        private string _itemName = string.Empty;
        private int _price = 0;
        public string Name { get { return _itemName; } }
        public int  Price { get { return _price; } }

        public Item(string name, int price)
        {
            _itemName = name;
            _price = price;
        }

    }

    public class Basket2
    {
        public Dictionary<Item,int> basket { get; set; }

        public List<string> GetReceipt()
        {
            List<string> list = new List<string>();
            foreach (var item in basket)
            {
                list.Add($"{item.Key.Name} x{item.Value} :{item.Key.Price * item.Value}");
            }
            int total = GetBasketCost();
            list.Add($"Total cost: {total}");

            return list;
        }

        int GetBasketCost()
        {
            int cost = 0;
            foreach (var item in basket)
            {
                cost = cost + (item.Key.Price * item.Value);
            }

            return cost;
        }
    } 
}
