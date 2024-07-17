using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Personal Finance Manager!");
        Console.WriteLine("Let's get started by creating a new user and adding some transactions.");
        Console.WriteLine();
        Console.Write("What is your new username? ");
        string newUser = Console.ReadLine();
        User user = new User(newUser);
        Console.WriteLine();
        Console.WriteLine("Please enter your salery amount: ");
        decimal salary = Convert.ToDecimal(Console.ReadLine());
        string choice = "y";
        while (choice != "n")
        {
            Console.WriteLine("Do you want to add a transaction? (y/n)");
            choice = Console.ReadLine();
            if (choice == "y")
            {
                Console.WriteLine("Please enter the amount: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the description: ");
                string description = Console.ReadLine();
                Console.WriteLine("Please enter the date: ");
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Is this an income or expense? (i/e)");
                string type = Console.ReadLine();
                if (type == "i")
                {
                    user.AddTransaction(new Income(amount, description, date));
                }
                else
                {
                    user.AddTransaction(new Expense(amount, description, date));
                }
            }
        }
            

        user.AddTransaction(new Income(salary, "Salary", DateTime.Now));
        user.AddTransaction(new Expense(200, "Groceries", DateTime.Now));
        user.AddTransaction(new Expense(50, "Utilities", DateTime.Now));
        
        user.DisplayTransactions();
        user.GenerateReport();
    }
}