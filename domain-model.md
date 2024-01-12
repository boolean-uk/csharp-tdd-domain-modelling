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
| `POSManager` | `PrintLine(Product product, int quantity)` |  Print a itemized receipt. | string |
| `POSManager`	  | `CalculateTotalCost(List<Product, int> shoppingItems) ` | Print a itemized receipt. | float    |
| `Basket` | `GtAllBasketItems()` | Print a itemized receipt. | List<Product, int> |
| `Basket` | `AddItemToBasket(Product product)` | Print a itemized receipt. | void |
| `Product` | `GetProductName()`|  Print a itemized receipt. | string |
| `Product` | `GetProductPrice()` |  Print a itemized receipt. | float |