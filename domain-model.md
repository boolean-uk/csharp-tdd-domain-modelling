#Domain Models In Here

### Exercise

Follow the same process as above to translate these two user stories into domain models.


## One
```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

| Classes         | Methods                                                          | Scenario                         | Outputs |
|-----------------|------------------------------------------------------------------|----------------------------------|---------|
| `Checkout.cs`   | `List<Item> myBasket` with items + price & quantity				 | Store items + price + quantity   | List    |
| `Checkout.cs`   | Method `AddToBasket(item,price,quantity)`						 | Store items + price + quantity   | Void    |
| `Checkout.cs`   | Method `CheckoutSum(basket)`									 | Sum cost for each item			| Int     |


## Two
```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

| Classes         | Methods																		     | Scenario                       | Outputs |
|-----------------|----------------------------------------------------------------------------------|--------------------------------|---------|
| `Checkout.cs  ` | Method `Receipt()`																 | Upon request, return receipt   | String  |
|				  |	- the returns the basket, quantity of each item and								 |								  |         |
|				  | - sum total (CheckoutSum() added as final item to list)							 |								  |			|