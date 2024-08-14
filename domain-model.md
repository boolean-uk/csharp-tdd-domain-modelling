#Domain Models In Here

========================================================================
USER STORY:
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.

DOMAIN MODEL:
Classes                       Methods                                               Scenario                               Outputs
Checkout      CalculateTotalSum(List<Items> itemsScanned)	     Calculate total sum of items scanned on checkout		float/double

=================================================================================================================================================
USER STORY:
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.

DOMAIN MODEL:
Classes                    Methods                                                                      Scenario                                               Outputs
Checkout     Receipt(List<Items> itemsBought, List<Items> itemsScanned)         Display information about bought items and items currently in basket        Items (Object)

========================================================================