

#Domain Models In Here
Class Basket
PROPERTIES:
    Dictionary<string, int> Items
Methods:
    bool Add(string product, int price, int ammount) 
        Bool True, out updated Dictionary with new items. 
    List<string> Receipt()
        Output List<string> Receipt with Deach item
