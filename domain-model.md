#Domain Models In Here'

```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```


| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
|`Basket`         |`totalCost(Dictionary<String, integer> basket)`| If basket is empty   | null    |
|                 |                                               | If basket has items  | integer |


```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```


| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
|`Basket`		  |`createReciept(Dictionary<String, integer> basket)`| If basket is empty  |null  |
|                 |                                                   | If basket has items |string|