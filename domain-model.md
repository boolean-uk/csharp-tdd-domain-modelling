#Domain Models In Here

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `CohortManager` | `search(List<String> cohorts, String name)` | If name is in list     | string  |
|                 |                                             | If name is not in list | string  |

```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `Basket`		  | `sum(List<String> items)`					|					     | int     |
|                 |                                             |						 |		   |

```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `Basket`		  | `printReceipt(List<String> items)`			|						 |List<Tuple<string, int>   |
|                 |                                             |						 |int	   |