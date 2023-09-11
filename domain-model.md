#Domain Models In Here

---Cohort story---
class               |       attribute                  | method                         | scenario                   |  output  
------------------------------------------------------------------------------------------------------------------------------------------
Cohort              | Name String                      |                                | if name is found in list   | match object 
ChohortManager      | List of cohorts                  | searchName string name: Cohort | if not                      | null


---story1---
class               |         attribute                          |       method                  | scenario                             | output  
-------------------------------------------------------------------------------------------------------------------------------------------------
Basket              | Dictionary, list of products               | calculateCostTotal, int       | total price of all items in basket   |
Product             | string name, int price                     |                               |                                      |


---story2---
class             |         property                          |       method            | scenario                                           | output  
--------------------------------------------------------------------------------------------------------------------------------------------------------------
Product           | string name of product, int price         |                         |                                                    |
Basket            | Dictionary, list of product purshased     | generateReceipt         | view list of purshased items, quantities and cost  | string receipt
Receipt           | GetDetailOfItem list and total cost       | getItemDetail           | likst of items, prices and cost                    | list of receipt
ItemDetail        | product and quantity                      | getTotal                | Price of product and quantity                      | sub total


---ex2---
class             |         property                          |       method        | scenario                                               | Output  
--------------------------------------------------------------------------------------------------------------------------------------------------------------
Basket           | Dictionary of products                     | AddProduct          | Add a new product or update existing one               |  
                 |                                            | TotalCost           | Calculate total cost of products in basket             | Total cost 
                 |                                            | MakeReceipt         | Generate a receipt for the current basket              | Receipt
Product          | name string, price int, quantity int       | AddQuantity         | Add quantity to an existing product                    |   
Receipt          | List of purshasedProducts                  | ViewTheReceipt      | generate a string represent of all products in receipt | Itemized recept 