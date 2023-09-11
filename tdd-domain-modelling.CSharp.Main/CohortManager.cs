using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

    namespace tdd_domain_modelling.CSharp.Main
    {
        public class Basket
        {
            private Dictionary<string, Product> products = new Dictionary<string, Product>();

            public void AddProduct(string productName, int price, int quantity = 1)
            {
                if (products.ContainsKey(productName))
                {
                    products[productName].Price = price;
                products[productName].AddQuantity(quantity);
                }
                else
                {
                    products[productName] = new Product(productName, price, quantity);
                }
            }

            public int TotalCost()
            {
                return products.Values.Sum(product => product.Price * product.Quantity);
            }

            public Receipt MakeReceipt()
            {
                return new Receipt(products.Values.ToList());
            }
        }

        public class Product
        {
            public string Name { get; }
            public int Price { get; set; }
            public int Quantity { get; set; }

            public Product(string name, int price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
        public void AddQuantity(int amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException("Cannot be negative");
            Quantity += amount;
        }
    }

        public class Receipt
        {
            private List<Product> purchasedProducts;

            public Receipt(List<Product> products)
            {
                purchasedProducts = products;
            }

            public string ViewTheReceipt()
            {
                return string.Join(", ", purchasedProducts.Select(product => $"{product.Name} ({product.Quantity}): {product.Price * product.Quantity}"));
            }
        }
    }
