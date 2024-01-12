using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        private List<Item> _items;
        public Basket()
        {
            _items = new List<Item>();
        }

        public List<Item> Items { get { return _items; } }

        public void Add(Item item)
        {
            _items.Add(item);
        }

        public int Total()
        {
            int total = 0;

            foreach (Item item in Items)
            {
                total += item.Price;
            }

            return total;
        }
    }
}
