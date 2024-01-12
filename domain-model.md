#Domain Models In Here

Customer has a basket (Dictionary) with wares (String), the amount of those wares (Int) and the price of a singular ware (Double). They want a double containing the total price for their wares.
|  Classes   | Methods                                             | Scenario                     | Outputs       |
|------------|-----------------------------------------------------|------------------------------|---------------|
| `Checkout` | `TotalCost(Dictionary<String, Int, Double> Basket)` | Sum together price and amount| Double (price)|
|            |                                                     | Basket is empty              | 0             |
|            |                                                     | Ware exists but amount is 0  | 0             |
|            |                                                     | Total price is a negative number  | -1 (error)|

Customer has a basket (Dictionary) with wares (String), the amount of those wares (Int) and the price of a singular ware (Double). They want a full reciept(dictionary) back with the total amount(double) together (tuple).
|  Classes   | Methods                                             | Scenario                     | Outputs       |
|------------|-----------------------------------------------------|------------------------------|---------------|
| `Overview` | `PrintReceipt(Dictionary<String, Int, Double> Basket)` | Sum together price and amount| Tuple<Dictionary Dictionary<String, Int, Double>,double>|
|            |                                                     | Basket is empty              | null             |
|            |                                                     | Ware exists but amount is 0  | null             |
|            |                                                     | Ware exists in multiple dictionary entries| not added a new, amount is increased on previous             |
|            |                                                     | Total price is a negative number  | -1 (error)|