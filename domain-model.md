#Domain Models In Here
EXERCISE 1:
STORY 1
As a supermarket shopper, So that I can pay for products at checkout, I'd like to be able to know the total cost of items in my basket.

STORY 2
As an organised individual, So that I can evaluate my shopping habits, 
I'd like to see an itemised receipt that includes the name and price of the products I bought as well as the quantity, and a total cost of my basket.

Class Shopper

PROPERTIES:
double totalCost
double itemCost
string itemName

Dictionary<itemName, itemCost> items

METHODS:
double addCosts(totalCost, itemCost)
returns:
totalCost

List<string> createReceipt (Dictionary items, double totalCost) 
return:
receipt (First index contains totalCost)