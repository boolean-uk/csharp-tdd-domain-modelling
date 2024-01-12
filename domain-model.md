#Domain Models In Here
	
```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

//USER STORY 1 - Supermarket
//Struct
Item
//VARIABLES
double Cost 
String Product Name


//CLASS
Inventory
//VARIABELS
List<Item> Basket 
Int TotCost (get - calls SumOfItems())
//METHODS
int SumOfItems()
	return a total of all items in basket
	return zero if empty


```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

//USER STORY 2
//CLASS
Reciept

//Variables
List<Item> Items
int TotalCost

//Methods
String ProduceOverview()
		Returns an itemized readable list with qty for identical items, and total sum


