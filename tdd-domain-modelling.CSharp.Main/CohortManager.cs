using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Item
    {
        public Item(string name, float price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
    }
    public class Basket
    {
        
        public List<Item> myBasket = new List<Item>();

        public void AddToBasket(string newProduct, float newPrice, int newQuantity)
        {
            Item currentItem = new Item(newProduct, newPrice, newQuantity); 
            
            if (myBasket.Contains(currentItem))
            {
                // if the product is already in the list,
                // just add to quantity
                int index = myBasket.IndexOf(currentItem);
                int oldQuantity = myBasket[index].Quantity;
                int totalQuantity = oldQuantity + newQuantity;
                myBasket[index].Quantity = totalQuantity;
            }
            else if (!myBasket.Contains(currentItem))
            {
                //create new object Item
                //add the product to the list
                myBasket.Add(currentItem);
            }

        }

        public float CheckoutSum()
        {
            float sumTotal = 0;
            foreach(Item item in myBasket)
            {
                float itemTotal = item.Price * item.Quantity;
                sumTotal += itemTotal;
            }
            return sumTotal;
        }

        public string GetReceipt()
        {
            StringBuilder Receipt = new StringBuilder();
            myBasket.ForEach(i => {
                Receipt.AppendLine($"{i.Name} {i.Price} {i.Quantity}");
            });
            Receipt.AppendLine($"Total {CheckoutSum().ToString()}");

            return Receipt.ToString();
        }
    }
}
