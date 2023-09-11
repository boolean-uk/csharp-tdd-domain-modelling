#Domain Models In Here

---supermarket---
class               |         property                           |       method                  | scenario                      | output  
-------------------------------------------------------------------------------------------------------------------------------------------------
basket              | list of products                           | addProduct                    | add product to basket         |
                    |                                            | totalCost                     | calculate cost of total basket| total cost int
product itself      | string product name, int product price     |                               |                               |


---organised individual---
class               |         property                           |       method                  | scenario                      | output  
-------------------------------------------------------------------------------------------------------------------------------------------------
a product           | string name of product, int price          |                               |                               |
a receipt           | list of product purshased                  | viewTheReceipt                | view list of purshased items  | string receipt