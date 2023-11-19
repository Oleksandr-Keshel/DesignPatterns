public class CreditCardPayment : IPaymentMethod
{
    public double Amount{ get;set; }
    public CreditCardPayment(double amount){
        Amount = amount;
    }

    public  void ProcessPayment()
    {
        System.Console.WriteLine("Processing credit card payment of $" + Amount );
    }
}