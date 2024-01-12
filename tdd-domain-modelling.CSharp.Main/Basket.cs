using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main

{
    /// <summary>
    /// The class basket. Can be used to find what items and its price. It keep also track of how many 
    /// items are in the basket and can caluclated the total sum of the items.
    /// </summary>
    public class Basket
    {
        private Dictionary<string, int> basket = new Dictionary<string, int>();
        private Dictionary<string, int> priceCatalogue = new Dictionary<string, int>();

        /// <summary>
        /// This method return all items in form of dic.
        /// </summary>
        /// <returns> Dictionary of the items in the basket </returns>
        /// <exception cref="NotImplementedException"></exception>
        public Dictionary<string, int> getItems() {

            return basket;
        }

        /// <summary>
        /// This method adds stuff into the basket
        /// 
        /// </summary>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Add(string itemToAdd, int itemsPrice)
        {
            if (basket.ContainsKey(itemToAdd))
            {
                basket[itemToAdd] += 1;
            }
            else {
                basket.Add(itemToAdd, 1);
                priceCatalogue.Add(itemToAdd, itemsPrice);
            }

        }

        /// <summary>
        /// This method can get the price of the input item.
        /// </summary>
        /// <param name="item"> item that the user wants to check up</param>
        public int getPrice(string item)
        {
            int price = priceCatalogue[item];
            return price;
        }

        /// <summary>
        /// This method simply returns the qty of the input item.
        /// </summary>
        /// <param name="item"> item that the user wants to check up</param>
        /// <returns> item's qty </returns>
        public int getQty(string item) {
            int qty = basket[item];
            return qty;
        }

        public int getTotalPrice()
        {
            int price = 0;
            price = basket.Sum(item => priceCatalogue[item.Key] * item.Value);
            //Console.WriteLine(price);
            return price;
        }

        //(List<string,int,qty>,int)
        public (List<(string, int, int)>, int) getReceipt() {
            //(List<(string, int, int)> items, int totalPrice) receipt;
            //(List<(string, int, int)>, int) receipt;
            //List<(string, int, int)> itemList = new List<(string, int, int)>();
            // string name, int qty, int price
            List<(string,int,int)> tempList = new List<(string,int,int)>();
            foreach (var pair in basket)
            {
                string name = pair.Key;
                int qty = pair.Value;
                int price = priceCatalogue[pair.Key];
                tempList.Add((name, qty, price));
                Console.WriteLine(name+qty+price);

            }
            //Console.WriteLine(getTotalPrice());
            //(List<(string, int, int)>, int) receipt = new(List<(string, int, int)>, int)<>();
            return (tempList, getTotalPrice());
        }
    }       

    
}
