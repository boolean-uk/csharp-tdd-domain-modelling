using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main 
{
    public class Basket
    {
        Dictionary<string, int> basket = new Dictionary<string, int>();

        public bool Add(String product, int price)
        {
            try
            {
                basket.Add(product, price);
                return true;
            } catch (ArgumentException)
            {
                Console.WriteLine($"{product} is already in basket");
                return false;
            }
        }
        public int Total()
        {
            int total = 0;
            Dictionary<string, List<int>> totalBasket = new Dictionary<string, List<int>>();
            totalBasket.Add("Milk", [35, 2]);
            totalBasket.Add("Eggs", [40, 2]);
            foreach (KeyValuePair<string, List<int>> kvp in totalBasket)
            {
                string product = kvp.Key;
                List<int> priceQt = kvp.Value;

                total = total + (priceQt[0] * priceQt[1]); // List<int> = {price per item, amount}

            }
            //throw new NotImplementedException();
            return total;
        }
    }
}
