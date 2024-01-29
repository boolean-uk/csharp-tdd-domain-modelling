#Domain Models In Here

```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

Class Item
- Properties
	string name;
	double price;

Class Basket
- Properties
	List<Item> items;
- Methods
	double GetTotal();
		returns total cost of items in basket.
	List<string> PrintReceipt();
		returns a list of all the items in the basket, and their quantities. And the total cost. 