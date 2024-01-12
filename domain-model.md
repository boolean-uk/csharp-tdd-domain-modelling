# Domain Models In Here

## Exercise 1
```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```
| Classes         | Methods                                     | Scenario               | Outputs       |
|-----------------|---------------------------------------------|------------------------|---------------|
| `Basket`	  | `getTotalCost(List<Item> items)`            | If items not empty     | cost of items |
|                 |                                             | If items empty	 | 0             |

```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```
| Classes         | Methods                                     | Scenario               | Outputs                                      |
|-----------------|---------------------------------------------|------------------------|----------------------------------------------|
| `Basket`        | `createReceipt(List<Item> items)`           | If items not empty     | {[ItemName, ItemPrice, Quantity], TotalPrice}|
|                 |                                             | If items empty	 | {[], 0}                                      |
