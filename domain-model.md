#Domain Models In Here

# user story 1 

As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.

# user story 2

As a supermarket shopper,
So that I can restock my cupboards,
I want to add products into my basket.

# user story 3

As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.


| Classes       | Methods                          | Scenario                                                   | Outputs    |
|---------------|----------------------------------|------------------------------------------------------------|------------|
| `Basket`      | `Add(String product, int price)` | Item with the provided name *is not* already in the basket | true       |
|               |                                  | Item with the provided name *is* already in the basket     | false      |
|               |  `GenerateReceipt()`             | Generate an itemized receipt                               | `Receipt`  |
| `Receipt`     |                                  |                                                            |            |
| `ReceiptItem` |                                  |                                                            |            |