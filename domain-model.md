#Domain Models In Here

```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

```C# 
struct Item
	PROPERTIES:
	public string itemName {get}
	public float cost {get}

	METHODS:
		public Item(string itemName, float cost)

Class Basket
	properties:
	public List<item> items {get}

	methods:
	public Basket() // initialize items list
	public void AddItem(string itemName, float cost)
	public float TotalCost(List<Item>) return the total cost of the basket
```


```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.

```

``` C#
struct Item
	PROPERTIES:
	public string itemName {get}
	public float cost {get}

	METHODS:
		public Item(string itemName, float cost)

Class Basket
	properties:
	public List<item> items {get}

	methods:
	public Basket() // initialize items list

	public void AddItem(string itemName, float cost)

	public float TotalCost(List<Item>) return the total cost of the basket

	public List<string> Receipt(List<item> items) 
		returns a list with:| Name | Price | Quantity |
		Last index of list  | TotalCost()             |
```