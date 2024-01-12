#Domain Models In Here

```
As a user,
So I can find a specific cohort,
I want to search a list of all cohorts by a cohort name.
```

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `CohortManager` | `search(List<String> cohorts, String name)` | If name is in list     | true    |
|                 |                                             | If name is not in list | false   |




```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

| Classes         | Methods											| Scenario               | Outputs |
|-----------------|-------------------------------------------------|------------------------|---------|
| `ReceiptManager`| `CalculateSum(List<Tuple<string, int>>)`		| the basket is not empty| sum	   |
|                 |													| the basket is empty	 | 0	   |




```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

| Classes         | Methods											| Scenario               | Outputs |
|-----------------|-------------------------------------------------|------------------------|---------|
| `ReceiptManager`| `CreateReceipt(List<Tuple<string, int, int>>)`  | the basket is not empty| list    |
|				  |													| basketisempty			 | error   |
|				  | `AddItemsToList(<Tuple<string, int, int>)`		|						 | list    |



As a supermarket shopper,
So that I can restock my cupboards,
I want to add products into my basket.
| Classes         | Methods											| Scenario               | Outputs |
|-----------------|-------------------------------------------------|------------------------|---------|
| Basket		  | AddItem(Item) | the basket is not empty| list    |
|				  |													| basketisempty			 | error   |
|				  | `AddItemsToList(<Tuple<string, int, int>)`		|						 | list    |


As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.