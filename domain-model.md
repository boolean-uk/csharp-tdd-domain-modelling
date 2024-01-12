#Domain Models In Here
### Exercise 1

| Classes | Fields | Type |
|-|-|-| 
| POSManager | | |
| Product | _name | string |
| Product | _price | float |

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `POSManager`	  | `calculateTotalCost(List<string, float> checkoutItems) ` | Show shopper their total cost at checkout    | float    |
| `POSManager` | `printReceipt(string[] receiptLines, float totalPrice)` | Print a itemized receipt | string[] |
| `POSManager` | `printLine(Product product, int quantity)` |  Print a itemized receipt | string |
| `Product` | `getProductName()`|  Print a itemized receipt | string |
| `Product` | `getProductPrice()` |  Print a itemized receipt | float |