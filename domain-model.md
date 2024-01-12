#Domain Models In Here

# Story 1

| Classes         | Methods                                     | Scenario               | Outputs                
|-----------------|---------------------------------------------|------------------------|-------------------------
| `Basket`        | `getTotalCost(List<Product> items)`         |If basket has items     | `total cost`
|				  |											    |If basket is empty      |     0
|                 |                                      	    |						 |	
|                 |                                             |If name is not in list  |     false   


# Story 2

| Classes         | Methods                                     | Scenario                         | Outputs | Members
|-----------------|---------------------------------------------|----------------------------------|---------|-----------
| `Basket`        |                                             |                                  |         | `HashMap<String, int> items` 
|                 |                                             |                                  |         |   (key is product name, value is price)
|                 | `add(String product, int price)`            | Item with the provided name *is  | true    |
|                 |                                             |  not* already in the basket      |         |
|                 |		`total()`								|								   |  int    |

