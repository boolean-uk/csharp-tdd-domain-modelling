using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class ReceiptItem
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int TotalPrice => Quantity * UnitPrice;
    }

    public class Receipt
    {
        public List<ReceiptItem> Items { get; set; }
        public int TotalCost => Items.Sum(item => item.TotalPrice);
    }

    public class Basket
    {
        private Dictionary<string, int> items;

        public Basket()
        {
            items = new Dictionary<string, int>();
        }

        public void Add(string product, int price)
        {
            if (!items.ContainsKey(product))
            {
                items[product] = price;
            }
            else
            {
                items[product] += price;
            }
        }

        public Receipt GenerateReceipt()
        {
            var receipt = new Receipt
            {
                Items = new List<ReceiptItem>()
            };

            foreach (var item in items)
            {
                receipt.Items.Add(new ReceiptItem
                {
                    ProductName = item.Key,
                    Quantity = 1, 
                    UnitPrice = item.Value
                });
            }

            return receipt;
        }
    }

}