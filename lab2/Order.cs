public class Order  
{
    public Dictionary<Product, int> order = new Dictionary<Product, int>(); 

    public void addProduct(Product product, int quantity){  
        order.Add(product, quantity);
    }
    public double TotalCost(){
        double totalCost = 0;
        foreach (var item in this.order){
            Product product = item.Key;
            int amount = item.Value;
            double productValue = product.Price * amount;
            totalCost += productValue;
        }
        return totalCost;

    }
}