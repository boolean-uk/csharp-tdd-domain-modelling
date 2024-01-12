using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class CohortManager
    {
        
        public bool Search(List<String> cohorts, String name) {
            return cohorts.Contains(name);
        }

    }


    public class Item {
        public string Name = "";
        public int Price = 0;
        public int Qantity = 0;


        public Item(string name, int price) {
            Name = name;
            Price = price;
        }
    }
    public class Basket {
        public List<Item> items = new List<Item>();

        public int total;


        public int calculateCost() {
            int cost = 0;
            foreach (Item item in items)
            {
                cost += item.Price;
            }
            return cost;
        }
    }
}
