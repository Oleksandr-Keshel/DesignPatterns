class Inventory
{
    public Dictionary<Product,int> products = new Dictionary<Product,int>();

    public void AddProduct(Product product, int stock){ 
        products.Add(product,stock);
    }
    private KeyValuePair<Product,int> getProduct(Product product){
        var productWithAmount =  products.SingleOrDefault( keyAndValue => keyAndValue.Key == product);
        return productWithAmount;
        
    }


    public bool isInStock(Product _product, int _quantity){ 
        
        var prodFromDict = getProduct(_product);
        var product = prodFromDict.Key;
        var stock = prodFromDict.Value;
        if(product == _product && stock >= _quantity){
            return true;
        } else {
            return false;
        }
    }

    public void RemovePurchasedProducts(Product _product, int _quantity){
        products[_product] -= _quantity;
        
    }
}