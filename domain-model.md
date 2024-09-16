#Domain Models In Here

Class Item

	- string itemName
	- double price


class Basket

	PROPERTIES
	- public List<item> items;


	METHODS
	- public bool addItemsToBasket(string itemName, double price)
	- public double totalCosts
	- List printReceipt string, prints each itemName, price and quantity of item & total price
	