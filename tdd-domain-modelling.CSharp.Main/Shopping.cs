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
        private int _itemId;
        public string Name { get { return _itemName; } }
        public int  Price { get { return _price; } }

        public int ItemId { get { return _itemId; } }

        public Item(string name, int price, int itemId)
        {
            _itemName = name;
            _price = price;
            _itemId = itemId;

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

    public class store
    {
        public Dictionary<int, Item> stock { get; set; }

        public store()
        {
            stock = new Dictionary<int, Item>();
            Item item = new Item("socks", 15, 1);
            Item item1 = new Item("apple", 5, 2);
            Item item2 = new Item("milk", 20, 3);
            stock.Add(item.ItemId, item1);
            stock.Add(item2.ItemId, item2); 
            stock.Add(item1.ItemId, item1);

        }
    }
    public class ShopingBasket
    {
        store store = new store();
        public Dictionary<int, Item> basket { get; set; }
        public ShopingBasket()
        {
            basket = new Dictionary<int, Item>();
        }

        public string AddItemToShopingBasket(int itemId)
        {
            

            if (!store.stock.ContainsKey(itemId))
            {
                return "not a valid id";
            }
            var item = store.stock[itemId];
            

            basket.Add(item.ItemId, item);
            return $"{item.Name} was added to the basket";
        }


        public string GetCostFromBasket()
        {
            int totalCost = 0;
            foreach (var item in basket)
            {
              totalCost = totalCost + item.Value.Price;
            }

            return $"the total cost of all: {basket.Count} items is: {totalCost}";
        }
    }
}
