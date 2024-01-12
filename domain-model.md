#Domain Models In Here
```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```
| Classes         | Methods                       | Scenario				                        | Outputs		           |
|-----------------|-------------------------------|-------------------------------------------------|--------------------------|
|  `CartManager`  |`sum(List<shopItem> cartItems)`|`Sum the price of each shopItem and return total`|result of sum of all items|
|                 |                               |`No item in cart to sum`                         |null                      |

```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```
| Classes         | Methods                             | Scenario                                                         | Outputs			                         |
|-----------------|-------------------------------------|------------------------------------------------------------------|---------------------------------------------|
|  `CartManager`  |`checkout(List<shopItem> cartItems)` |`Add cartItems to a cartDictionary, key=itemName value=quantity. `|Dictionary with all cartItems                |
|                 |`makeReceipt(Dictionary<string, int>`|`Compare item names in cartDictionary to global price dictionary.`|List with string of items, quantity and price|