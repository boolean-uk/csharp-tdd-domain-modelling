#Domain Models In Here

Cohort List
| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `CohortList`	  | `search(List<String> cohorts, String name)` | If name is in list     | bool true    |
|                 |                                             | If name is not in list | bool false   |


Supermarkt Shopper
| Classes					  | Methods                                     | Scenario								| Outputs			|
|-----------------			  |---------------------------------------------|------------------------				|---------			|
| `ShoppingListTotalPrice`	  | `Dictionary<string, int>				    | Add prices of shoppinglist items		| int TotalPrice    |



Shopping List
| Classes							  | Methods                                     | Scenario									| Outputs			|
|-----------------					  |---------------------------------------------|------------------------					|---------			|
| `ShoppingListItem`				  | `Dictionary <"Name", price>`				| Define items and their price				| int TotalPrice    |
| `ShoppingListItemQuantity`		  | `Multiply (int a * int b)`					| Multiply quantity of items on list		| int TotalPrice    |
| `ShoppingListTotalCost`			  | `Add(int a + int b)`					    | Add all total prices						| int TotalPrice    |
