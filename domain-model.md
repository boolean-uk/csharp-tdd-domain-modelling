#Domain Models In Here

```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

| Classes        | Methods       | Scenario                             | Outputs   |
|----------------|---------------|--------------------------------------|-----------|
| `ShoppingCart` | `totalCost()` | If summary is successfully aquired   | int price |
|                |               | If summary is unsuccessfully aquired | -1        |

```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

| Classes        | Methods          | Scenario         | Outputs        |
|----------------|------------------|------------------|----------------|
| `ShoppingCart` | `printReceipt()` | If successfull   | string receipt |
|                |                  | If unsuccessfull | string.empty() |