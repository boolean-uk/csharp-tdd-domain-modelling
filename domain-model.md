#Domain Models In Here
### Exercise 1

| Classes | Fields | Type |
|-|-|-| 
| POSManager | | |
| Product | `string _name` `float _price` |
| Basket | `List<Product, int> contents` |

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `POSManager`	  | `CalculateTotalCost(List<string, float> shoppingItems) ` | Show shopper total cost.    | float    |
| `POSManager` | `PrintReceipt(string[] receiptLines, float totalPrice)` | Print a itemized receipt. | string[] |
| `POSManager` | `PrintLine(Product product, int quantity)` |  Print a line with product information. | string |
| `POSManager`	  | `CalculateTotalCost(List<Product, int> shoppingItems) ` | Show shopper total cost. | float    |
| `Basket` | `GtAllBasketItems()` | Retrieve all items currently in the basket. | List<Product, int> |
| `Basket` | `AddItemToBasket(Product product)` | Add item to the basket. | void |
| `Product` | `GetProductName()`|  Get product name. | string |
| `Product` | `GetProductPrice()` |  Get product price. | float |