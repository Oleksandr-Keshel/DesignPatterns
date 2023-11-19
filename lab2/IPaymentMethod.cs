interface IPaymentMethod
{
    double Amount { get; set; }

    void ProcessPayment();
}