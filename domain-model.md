#Domain Models In Here

---supermarket---
class               |         property                           |       method                  | scenario                        | output  
-------------------------------------------------------------------------------------------------------------------------------------------------
Basket              | Dictionary, list of products               | addProduct                    | add product to basket            |
                    |                                            | totalCost                     | calculate cost of total basket   | total cost int
                    |                                            | makeReceipt                   | generates a receipt from basket  | receipt generated
Product             | string name, int price                     |                               |                                  |



---organised individual---
class               |         property                           |       method                  | scenario                      | output  
-------------------------------------------------------------------------------------------------------------------------------------------------
a product           | string name of product, int price          |                               |                               |
a receipt           | Dictiomnary, list of product purshased     | viewTheReceipt                | view list of purshased items  | string receipt