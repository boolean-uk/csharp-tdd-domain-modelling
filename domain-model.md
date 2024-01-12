#Domain Models In Here

**User Story 1:**

As a supermarket shopper,

I'd like to be able to know the total cost of items in my basket,

So that I can pay for products at checkout.


  

**Domain Model:**

Public Class: Basket()

- public Dictionary<string Item, flout price> items { "milk": 1.99, "bread": 0.99, "eggs": 1.99 }

- public Dictionary<string Item, int quantity> itemsInBasket { "milk": 1, "bread": 2, "eggs": 1 }

- void AddItem(string Item, int quantity) {add item to itemsInBasket}

- void RemoveItem(string Item, int quantity) {remove item from itemsInBasket}

- flout GetTotalCost(itemsInBasket) { returns totalCost by adding up the price of each item in itemsInBasket }

/*-------------------------------------------------------------------------------------------------------------------------*/

**User Story 2:**

As an organised individual,

I'd like to see an itemised receipt that includes the name and price of the products

I bought as well as the quantity, and a total cost of my basket,

So that I can evaluate my shopping habits.



**Domain Model:**

Class: Receipt()

- public Dictionary<string Item, flout price> items { "milk": 1.99, "bread": 0.99, "eggs": 1.99 }

- public Dictionary<string Item, int quantity> itemsInBasket { "milk": 1, "bread": 2, "eggs": 1 }

- flout GetTotalCost(itemsInBasket) { returns totalCost by adding up the price of each item in itemsInBasket }

- string GetReceipt(itemsInBasket, totalCost) { returns a string of a detailed receipt, including the name, price and the quantity of each item in itemsInBasket, and the totalCost }

