class Credit : IPaymentMethod
{
    public double Amount{ get;set; }
    public Credit(double amount){
        Amount = amount;
    }
    
    public void ProcessPayment()
    {
        System.Console.Write("Specify the credit term(in months): ");
        int numOfMonths = Convert.ToInt32(Console.ReadLine());  // number of months of credit
        double interestRate = 0.03;   // 3%
        DateOnly paymentDay = DateOnly.FromDateTime(DateTime.Now); 
        var payForCurentMonth = Amount / numOfMonths; 
        System.Console.WriteLine("Monthly payment schedule:");

        for(int i=0; i < numOfMonths; i++){
            payForCurentMonth += Amount / numOfMonths * interestRate; //  amount / numOfMonths + % 
            System.Console.WriteLine("\t" + paymentDay.AddMonths(i) + " amount due: " + payForCurentMonth);
        }
    }
}