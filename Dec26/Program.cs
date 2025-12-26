using System;
using System.Data.Common;
using System.Runtime.InteropServices.Marshalling;
// namespace PartialDemo
// {
namespace CalculatorApp
    {
        public delegate int CalculatorDelegate(int num1, int num2);
        class Program
        {
            public static void Main(string[] args)
            {
                // IPayment payment;
                // payment=new CreditCardPayment();
                // payment.Refund(1000);
                // payment.Pay(3452);

                // PartialEmployee part=new PartialEmployee();
                // part.FirstName="Harsh";
                // part.DisplayEmployeeDetails();
                // part.DisplayFullName();
                 
                // Calculator calculator=new Calculator(); 
                // CalculatorDelegate calculateAdd=new CalculatorDelegate(calculator.Add);
                // CalculatorDelegate calculateSub=new CalculatorDelegate(calculator.Sub);
                // CalculatorDelegate calculateMul=new CalculatorDelegate(calculator.Mul);
                // CalculatorDelegate calculateDiv=new CalculatorDelegate(calculator.Div);
                // CalculatorDelegate calculateMulticast;
                // //calling the delegate single cast delegate
                // Console.WriteLine(calculateAdd(4,5));
                // Console.WriteLine(calculateSub(6,5));
                // Console.WriteLine(calculateMul(9,5));
                // Console.WriteLine(calculateDiv(43,5));
                // //multicast delegate
                // calculateMulticast=calculateAdd;
                // calculateMulticast+=calculateSub;
                // calculateMulticast-=calculateMul;
                // calculateMulticast+=calculateDiv;
                // Console.WriteLine(calculateMulticast(30,3));


                //practice1.cs
                Animal animal=new Animal();
                Dog dog=new Dog();
                Cat cat=new Cat();
                Console.WriteLine("Enter n: ");
                int n=int.Parse(Console.ReadLine());
                if(n<=0)
                Console.WriteLine("Please Enter a valid integer: ");
                else{
                string[] arr=new string[n];
                for(int i = 0; i < n; i++)
            {
                arr[i]=Console.ReadLine();
            }
            Console.WriteLine("Sound of the Animal in array: ");
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i]=="animal")
                animal.MakeSound();
                else if(arr[i]=="dog")
                dog.MakeSound();
                else
                cat.MakeSound();
            }
                }
            }
        }
    }
// }