using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class CohortManager
    {
        public Dictionary<string, int> items = new Dictionary<string, int>()
        {
            {"Aplles2",3},
            {"Oranges2",2},
            {"Bananas1",7},
            {"Pineapple3",10},
            {"Coconut4",5}
        };

        public bool add(string product, int price)
        {
            foreach(KeyValuePair<string, int> kvp in items)
            {
                if (kvp.Key.Equals(product))
                {
                    return false;
                }
            }
            items.Add(product, price);
            return true;
        }
        public int totalCost()
        {
            int total = 0;
            foreach (KeyValuePair<string, int> item in items)
            {
                total += item.Value;
            }
            return total;
        }

        public List<string> Receipt(Dictionary<string, int> items)
        {

            List<object> objectList = new List<object>();
            objectList.Add("hi");
            objectList.Add(1);
            foreach (object item in objectList)
            {
                if (item is string)
                {
                    // do something
                } else if (item is int)
                {
                    // do something else
                }else
                {
                    // whatever
                }
            }
            List<string> list = new List<string>();
            foreach (KeyValuePair<string, int> item in items)
            {
                string s1 = item.Key.Remove(item.Key.Length - 1, 1);
                list.Add("Item: " + s1 + " Quantity: " + item.Key[item.Key.Length - 1] + " Value: " + item.Value);
            }
            return list;
        }
    }
}
