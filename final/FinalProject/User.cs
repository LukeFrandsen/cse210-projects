class User
    {
        private string Name { get; set; }
        private List<Transaction> transactions;
        private Budget budget;

        public User(string name)
        {
            Name = name;
            transactions = new List<Transaction>();
            budget = new Budget(0);
        }
        public void CreateBudget(decimal limit)
        {
            budget.SetBudgetLimit(limit);
        }
        public void AddTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
            
            if (transaction is Expense)
            {
                budget.AddExpense((Expense)transaction);
                if (!IsWithinBudget())
                {
                    var notification = new Notification("You have exceeded your budget limit!");
                    notification.Send();
                }
            }
        }
        public void DisplayTransactions()
        {
            Console.WriteLine($"Transactions for {Name}:");
            foreach (var transaction in transactions)
            {
                transaction.Display();
            }
        }
        public bool IsWithinBudget()
        {
            decimal totalExpenses = 0;

            foreach (var expense in budget.GetExpenses())
            {
                totalExpenses += expense.Amount;
            }

            return totalExpenses <= budget.GetBudgetLimit();
        }
        public void GenerateReport()
        {
            decimal totalIncome = 0;
            decimal totalExpenses = 0;
            decimal totalBudget = budget.GetBudgetLimit();

            foreach (var transaction in transactions)
            {
                if (transaction is Income)
                {
                    totalIncome += transaction.Amount;
                }
                else if (transaction is Expense)
                {
                    totalExpenses += transaction.Amount;
                }
            }

            Console.WriteLine("\nFinancial Report:");
            Console.WriteLine($"Total Income: {totalIncome}");
            Console.WriteLine($"Total Expenses: {totalExpenses}");
            Console.WriteLine($"Budget Balance: {totalExpenses} / {totalBudget}");
            Console.WriteLine($"Net Balance: {totalIncome - totalExpenses}");
        }
    }