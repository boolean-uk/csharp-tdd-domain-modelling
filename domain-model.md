#Domain Models In Here
Domain Model:

Classes |Properties                                         |  Methods                |Scenario|            |   Outputs                                |
Basket  |Dictionary<string itemName,  double cost> itemPrice|totalCost(itemsInBasket) |Calculate total cost |total cost by summing all items with price|
		|Dictionary<string itemName, int amount> itemsInBasket
		| Methods                             |Scenario                                   |       Outputs                             |
Reciep  | String generateReceipt(itemsInBaske)|Prints to user price and name of a product |Produces a readable output for user(string)|