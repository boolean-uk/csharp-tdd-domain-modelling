#Domain Models In Here

```
As a user,
So I can find a specific cohort,
I want to search a list of all cohorts by a cohort name.
```

Here is how one might design a domain model for the above user story:

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `CohortManager` | `search(List<String> cohorts, String name)` | If name is in list     | true    |
|                 |                                             | If name is not in list | false   |
____________________________________________________________________________________________________



```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```


| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `Basket`        | `TotalCost()`                               |                        | int     |

// I want to see what int returns TotalCost();
____________________________________________________________________________________________________


```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```



| Classes         | Methods                                      | Scenario               | Outputs |
|-----------------|----------------------------------------------|------------------------|---------|
| `Person`        | `AddPurchase(Product product, int quantity)` | Add product to person  |  void   |
|                 |                                              |                        |         |
|  `Product`      | `getName(), getPrice()`                      |                        |str, int |
|                 |                                              |                        |         |
|   `Receipt`     | `getReceipt(Person person)`                  |     receipt for person |receipt  |
|                 |                                              |                        |         |
|`ReceiptProduct` |`getName(), getPrice(), getQuantity(), getTotal()`  itemized receipt   |str, int,|
|                 |                                              |                        | int, int|
|                 |                                              |                        |         |
_____________________________________________________________________________________________________