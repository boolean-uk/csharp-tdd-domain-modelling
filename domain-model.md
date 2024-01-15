```
As a user,
So I can find a specific cohort,
I want to search a list of all cohorts by a cohort name.
```


Class: CohortManager
Method: FindCohort(string name)
Scenario: name is a substring of cohort name. Return: list of cohort names that name is a substing of
Scenario: name is not a substring of any cohort. Return: Empty list

```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

Class: ShoppingCart. Method: double CalculateTotal()
Class: Item. Method: double GetPrice()
Scenario: There are a number of items in the cartList. Out: CalculateTotal()

```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

Class: Checkout. Method: GetReceipt()
Class: Item. Method: GetName()
Class: Shopper. Method: AddReceit(receit). Method: GetReceits()
Scenario: The shopper buys something. Void: Shopper.AddReceit(Checkout.GetReceit())
Scenario: The shopper wants to look at their reciets. Out: Shopper.GetReceits()


