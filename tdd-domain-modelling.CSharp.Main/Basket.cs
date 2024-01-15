using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Basket
{

        

        public Dictionary<string, int> Items { get; set; } = new Dictionary<string, int>();


        public bool AddItem(string name, int value)
        {
            if (Items.ContainsKey(name))
            {
                return false;
            } else
            {
                this.Items.Add(name, value);
                return true;
            }
            
        }

        public int TotalBasketCost()
        {

            int totalcost = 0;
            foreach (var item in Items)
            {
                totalcost += item.Value;
            }

            return totalcost;
        }

    }
}
