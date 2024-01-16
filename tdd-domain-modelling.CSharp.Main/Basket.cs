using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        // Properties
        public Dictionary<String, int> Items { get; set; }

        //constructor
        public Basket() 
        {
            Items = new Dictionary<String, int>();
        }
        //method1, add item to basket
        public void addToBasket(String productName, int price)
        {
            Items.Add(productName, price);
        
        }
        //method2, return the total price
        public int total() 
        {
            List<int> totalValues = Items.Values.ToList();
            return (totalValues.Sum());
        }
    }
}