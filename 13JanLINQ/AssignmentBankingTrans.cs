// using System;
// using System.Transactions;
// class Account
// {
//     public string AccountNumber { get; set; }
//     public decimal Balance { get; set; }

//     public decimal Deposite(decimal amount)
//     {
//         try{
//             if (amount < 0)
//             {
//                 throw new ArgumentException();
//             }
//         if(amount>0){
//         Console.WriteLine($"Amount {amount} added succesfully.");
//         Balance+=amount;
//         }
//         }
//         catch(ArgumentException e)
//         {
//             Console.WriteLine("Deposite Amount must be positive");
//         }
//         return Balance;
        
//     }
//     public decimal Withdraw(decimal amount)
//     {
//         try
//         {
//             if(amount>0 && amount <= Balance)
//             {
//                 Balance-=amount;
//             }
//             if(amount<=0)
//             throw new ArgumentException("Withdrawal amount must be positive");
//             if(amount>Balance)
//             throw new InvalidOperationException("Insufficient funds");
//         }
//         catch(ArgumentException e)
//         {
//             Console.WriteLine(e.Message);
//         }
//         catch(InvalidOperationException e)
//         {
//             Console.WriteLine(e.Message);
//         }
//         return Balance;
//     }
    
//         public static void Main(string[] args)
//         {
//             Dictionary<string,decimal> dict=new Dictionary<string, decimal>();
//             dict.Add("123454",6543.65m);
//             dict.Add("345645",2345.65m);
//             dict.Add("876544",8765.65m);
//             dict.Add("987654",5643.65m);
//             Console.WriteLine("Enter Account Number: ");
//             string acc=Console.ReadLine();
//             decimal bal=0;
//         foreach (var ele in dict)
//         {
//             if (acc == ele.Key)
//             {
//                 Console.WriteLine("Account found!");
//                 Console.WriteLine("Balance: " + ele.Value);
//                 bal=ele.Value;
//                 break;
//             }
//         }
   
//         Console.WriteLine("1: Deposite");
//         Console.WriteLine("2:Withdraw");
//         int input=int.Parse(Console.ReadLine());
//         decimal opAmount=int.Parse(Console.ReadLine());
//         Account account=new Account();
//         decimal result=0;
//         if (input == 1)
//         {
//            result= account.Deposite(opAmount);
//            Console.WriteLine(result+bal);
//            dict[acc]=result+bal;
//         }
//         else if (input == 2)
//         {
//            result= account.Deposite(opAmount);
//            Console.WriteLine(result+bal);
//            dict[acc]=result+bal;
//         }
//         else
//         {
//             Console.WriteLine("Invalid input please press 1 or 2");
//         }

//         Console.WriteLine("\n\n\n");
//         foreach (var item in dict)
//         {
//             Console.WriteLine("Account: " + item.Key + "  Balance: " + item.Value);
//         }


//     }
// }