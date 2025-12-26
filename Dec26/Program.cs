using System;
namespace PartialDemo{
class Program
{
    public static void Main(string[] args)
    {
        // IPayment payment;
        // payment=new CreditCardPayment();
        // payment.Refund(1000);
        // payment.Pay(3452);

        PartialEmployee part=new PartialEmployee();
        part.FirstName="Harsh";
        part.DisplayEmployeeDetails();
        part.DisplayFullName();
    }
}
}