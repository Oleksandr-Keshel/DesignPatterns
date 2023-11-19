class PurchaseFacade
{
    private Inventory Inventory;
    private IPaymentMethod PaymentMethod; 

    public PurchaseFacade(Inventory inventory){
        this.Inventory = inventory;
    }

    public void Purchase(Order order, string paymentMethod){    
        //1. checking whether we have a list of goods in the inventory
        bool isEnoughProducts = true;
        foreach(var item in order.order){
            isEnoughProducts = Inventory.isInStock(item.Key,item.Value);
            if(!isEnoughProducts){
                System.Console.WriteLine("Unfortunately, we currently don't have enough products in stock");
                break;
            }
        }

        //2. if we have a list of products, then proceed to payment
        if(isEnoughProducts){
            System.Console.WriteLine("These products are in stock!");
            Payment payment = new Payment();
            this.PaymentMethod = payment.MakePayment(order, paymentMethod);
            this.PaymentMethod.ProcessPayment();
            

            //3. after successful payment, remove the purchased products from the inventory
            foreach (var item in order.order)
            {
                var product = item.Key;
                var quantity = item.Value;

                Inventory.products[product] -=  quantity;
            }
            System.Console.WriteLine("Thank you for your purchase.");
        }

    }
    public void Purchase(Product product, string paymentMethod){ 
        int quantity = 1;
        Order order = new Order();  
        order.addProduct(product,quantity);  // create an order with one product
        this.Purchase(order,paymentMethod);     
    }
    


}