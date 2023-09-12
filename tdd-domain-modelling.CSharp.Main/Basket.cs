using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        private Dictionary<string, int> _items = new Dictionary<string, int>();
        //public int Total { get; set; }

        public void AddToShoppingCart(string item, int price)
        {
            _items.Add(item, price);
        }

        public string Receipt()
        {
            // Assert.IsTrue(receipt == "(banana:1)-Total(1)");
            StringBuilder stringBuilder = new StringBuilder(); 

            foreach (var item in _items) 
                {
                stringBuilder.Append($"({item.Key}:{item.Value})");
                }

            stringBuilder.Append($"-Total({this.Total})");
            return stringBuilder.ToString();
        }

        public int Total { get {  return _items.Sum(x => x.Value); } }
    }
}
