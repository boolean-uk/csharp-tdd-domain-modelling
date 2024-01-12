#Domain Models In Here


As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.

Domain Model:

Class Basket
Properties
public Dictionary<string, int> basket (get, readonly)

Methods

int TotalCost()
- returns total cost of items.

------------------------------------------------------------------------------------------------------

As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.

Domain Model:

Class Item
Propetries 
public int price (get, readonly)
public string name (get, readonly)

Class Basket
Properties
public Dictionary< Item, int> products (get, set)   //change to read/write (changed from readonly to read/write)

Methods
List<string> GetReceipt()
- returns a Tuple with a Dictionary of (items and quantity) and total cost . //return a string or list of strings with the data (changed from returning a tuple with the items and the total cost to return a list of string)

int GetBasketCost()
returns int cost form products.

