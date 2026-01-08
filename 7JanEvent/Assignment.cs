using System;
public interface Ireportable
{
    string GetSummary();
}
public abstract class Transaction:Ireportable
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public double Amount { get; set; }
    public string Description { get; set; }
    public Transaction(int id,DateTime date,double amount,string description)
    {
        this.Id=id;
        this.Date=date;
        this.Amount=amount;
        this.Description=description;
    }
    public abstract string GetSummary();
}
public class IncomeTransaction : Transaction
    {
        public string Source { get; set; }

        public IncomeTransaction(int id, DateTime date, double amount, string description, string source)
            : base(id, date, amount, description)
        {
            Source = source;
        }

        public override string GetSummary()
        {
            return $"[INCOME] {Date} | {Amount} | Source: {Source} | {Description}";
        }
    }
    public class ExpenseTransaction : Transaction
    {
        public string Category { get; set; }

        public ExpenseTransaction(int id, DateTime date, double amount, string description, string category)
            : base(id, date, amount, description)
        {
            Category = category;
        }

        public override string GetSummary()
        {
            return $"[EXPENSE] {Date} | {Amount} | Category: {Category} | {Description}";
        }
    }
    public class Ledger<T> where T : Transaction
    {
        private  List<T> transactions = new List<T>();

        public void AddEntry(T entry)
        {
            transactions.Add(entry);
        }

    public List<T> GetTransactionsByDate(DateTime date)
    {
        List<T> result = new List<T>();

        foreach (T t in transactions)
        {
            if (t.Date.Date == date.Date)
            {
                result.Add(t);
            }
        }

        return result;
    }

    public double CalculateTotal()
    {
        double total = 0;

        foreach (T t in transactions)
        {
            total = total + t.Amount;
        }

        return total;
    }

    public List<T> GetAll()
        {
            return transactions;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DIGITAL PETTY CASH LEDGER ===\n");


            Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();

            incomeLedger.AddEntry(
                new IncomeTransaction(
                    id: 1,
                    date: DateTime.Now,
                    amount: 500,
                    description: "Petty cash replenishment",
                    source: "Main Cash"
                )
            );
            Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();

            expenseLedger.AddEntry(
                new ExpenseTransaction(
                    id: 2,
                    date: DateTime.Now,
                    amount: 20,
                    description: "Bought pens and paper",
                    category: "Stationery"
                )
            );

            expenseLedger.AddEntry(
                new ExpenseTransaction(
                    id: 3,
                    date: DateTime.Now,
                    amount: 15,
                    description: "Snacks for team",
                    category: "Food"
                )
            );

    
            double totalIncome = incomeLedger.CalculateTotal();
            double totalExpense = expenseLedger.CalculateTotal();
            double netBalance = totalIncome - totalExpense;

            Console.WriteLine($"Total Income   : {totalIncome:C}");
            Console.WriteLine($"Total Expenses : {totalExpense:C}");
            Console.WriteLine($"Net Balance    : {netBalance:C}\n");

            // 4. Polymorphism Demo
            Console.WriteLine("=== TRANSACTION SUMMARY REPORT ===");

            List<Transaction> allTransactions = new List<Transaction>();
            allTransactions.AddRange(incomeLedger.GetAll());
            allTransactions.AddRange(expenseLedger.GetAll());

            foreach (Transaction t in allTransactions)
            {
                Console.WriteLine(t.GetSummary());
            }
        }
    }
