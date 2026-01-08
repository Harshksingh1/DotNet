using System;

class Assignment
{
    public static void Main(string[] args)
    {
        // 1. Input number of branches and months
        Console.Write("Enter number of branches: ");
        int branches = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of months: ");
        int months = Convert.ToInt32(Console.ReadLine());

        // 2. Create 2D array
        int[,] sales = new int[branches, months];

        // 3. Accept sales data
        for (int i = 0; i < branches; i++)
        {
            Console.WriteLine($"\nEnter sales for Branch {i + 1}:");
            for (int j = 0; j < months; j++)
            {
                Console.Write($"Month {j + 1}: ");
                sales[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int highestSale = sales[0, 0];

        // 4. Calculate total per branch & highest sale
        Console.WriteLine("\nTotal Sales Per Branch:");
        for (int i = 0; i < branches; i++)
        {
            int branchTotal = 0;
            for (int j = 0; j < months; j++)
            {
                branchTotal += sales[i, j];

                if (sales[i, j] > highestSale)
                {
                    highestSale = sales[i, j];
                }
            }
            Console.WriteLine($"Branch {i + 1}: {branchTotal}");
        }

        // 5. Display highest sale
        Console.WriteLine("\nHighest Monthly Sale Across All Branches: " + highestSale);
    }
}
