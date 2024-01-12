### Exercise

Follow the same process as above to translate these two user stories into domain models.


### Domain Model 1
Class:                  Methods:                                    Returns
Basket      CalculateCost(Dictionary<string name, int price>) -> return int (total cost)

| Classes | Members | Methods                                                     | Returns                 |
|---------|---------|-------------------------------------------------------------|-------------------------|
| Basket  |         | CalculateCost(Dictionary < string   name,   int   price > ) | return int (total cost) |
|         |         |                                                             |                         |

### Domain Model 2

| Classes | Members       | Methods        | Returns                                                                                                    |
|---------|---------------|----------------|------------------------------------------------------------------------------------------------------------|
| Basket  | List < Item > | PrintReciept() | Returns a List<string> containing the name, price and quantity, With a total cost.                         |
|         | int total     |                |                                                                                                            |
| Item    | string name   |                |                                                                                                            |
|         | int price     |                |                                                                                                            |
|         | int quantity  |                |                                                                                                            |


