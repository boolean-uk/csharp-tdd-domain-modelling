
#Domain Models In Here

### Exercise

Follow the same process as above to translate these two user stories into domain models.


# Domain Model 1
Class:                  Methods:                                    Returns
Basket      CalculateCost(Dictionary<string name, int price>) -> return int (total cost)

| Classes | Members | Methods                                                     | Returns                 |
|---------|---------|-------------------------------------------------------------|-------------------------|
| Basket  |         | CalculateCost(Dictionary < string   name,   int   price > ) | return int (total cost) |
|         |         |                                                             |                         |

# Domain Model 2

| Classes | Members       | Methods        | Returns                                                                                                    |
|---------|---------------|----------------|------------------------------------------------------------------------------------------------------------|
| Basket  | List < Item > | PrintReciept() | Returns a List<List<Item>, int> (items, total cost) containing the name, price and quantity, With a total cost. |
| Item    | string name   |                |                                                                                                            |
|         | int price     |                |                                                                                                            |
|         | int quantity  |                |                                                                                                            |
