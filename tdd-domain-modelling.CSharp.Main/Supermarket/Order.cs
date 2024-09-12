using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main.Supermarket
{
    public class Order
    {
        private List<Tuple<Product, int>> _items;
        public Order()
        {
            _items = new List<Tuple<Product, int>>();
        }

        public void AddItem(Product product, int amount)
        {
            _items.Add(Tuple.Create(product, amount));
        }

        public decimal TotalCost()
        {
            decimal totalCost = 0m;
            foreach (var item in _items) totalCost += item.Item1.Price * item.Item2;
            return totalCost;
        }
        public string GenerateItimizedReceipt()
        {
            StringBuilder receipt = new StringBuilder();
            receipt.AppendLine($"{FixedLengthString("QTY")}{FixedLengthString("ITEM")}{FixedLengthString("PRICE")}");
            foreach (var item in _items)
            {
                decimal price = item.Item1.Price * item.Item2;
                receipt.AppendLine(FixedLengthString(item.Item2.ToString()) + FixedLengthString(item.Item1.Name) +
                    FixedLengthString(price.ToString()));
            }
            receipt.AppendLine($"{FixedLengthString("TOTAL")}{FixedLengthString("--")}{FixedLengthString(TotalCost().ToString())}");
            return receipt.ToString();
        }

        public string FixedLengthString(string input)
        {
            int fixedLength = 25;
            int minSpaceAtEnd = 7;
            if (input.Length >= fixedLength - minSpaceAtEnd)
            {
                return input.Substring(0, fixedLength - minSpaceAtEnd) + "." + new string(' ', minSpaceAtEnd - 1);
            }
            return input + new string(' ', fixedLength - input.Length);

        }

        public List<Tuple<Product, int>> Items { get { return _items; } }


    }
}

