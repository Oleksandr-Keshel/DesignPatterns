class Payment
{
    public IPaymentMethod MakePayment(Order order,string paymentMethod){
        if(paymentMethod == "Credit card"){
            return new CreditCardPayment(order.TotalCost());   
        }else if(paymentMethod == "Credit"){
            return new Credit(order.TotalCost());
        }else{
            throw new Exception($"Payment by {paymentMethod} is not available");
        }
    }
}