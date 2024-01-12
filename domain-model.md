#Domain Models In Here

As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.

As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.

# Physical solution:
| Class | properties |
|---|---|
| Product | `string Name`, `double Price` |
| Basket | `Dictionary<Product, Quantity> Entry`|


| Class | Method | Scenario | Output |
|---|---|---|---|
| Basket | `TotalCost()` | Basket contains items | `int` Total `Price` of all items in basket |
||| Basket does not contain items | `int` `0` |
| Basket | `Display()` | Basket contains items | `void` Displays a itemised receipt with the `Name`, `Price` and `Quantity` of the `Product`s, as well as `TotalCost()`, of basket. |
| || Basket does not contain items | `void` Displays a message which clearifies that the basket is empty |
