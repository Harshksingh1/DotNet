using System;
class UpiPayment : IPayment
{
  public void Pay(double amount)
  {

    Console.WriteLine("Amount is "+amount);

    // Implementation for payment processing
  }

  public void Refund(double amount)
  {

    Console.WriteLine("Refund amount is "+amount);
    // Implementation for refund processing
  }
}