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

| Classes  | Members								    | Methods	    | Scenario				     | Output |
|-------------------------------------------------------------------------------------------------------------|
| Customer | Dictionary<String product, int price> item | totalAmount() | Check total cost of basket | float  |


 
| Classes   | Members  							         | Methods								      | Scenario							  | Output  |
|-------------------------------------------------------------------------------------------------------------------------------------------------------|
| Customer2 | Dictionary<String product, int price> item | totalAmount()						      | Check total cost of basket			  | float   |
|			|										     | showReceipt(Dictionary<item, int quantity) | Print receipt with items and quantity | list    |	




