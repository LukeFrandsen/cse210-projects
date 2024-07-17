class User
    {
        public string Name { get; private set; }
        private List<Transaction> transactions;

        public User(string name)
        {
            Name = name;
            transactions = new List<Transaction>();
        }

        public void AddTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
        }

        public void DisplayTransactions()
        {
            Console.WriteLine($"Transactions for {Name}:");
            foreach (var transaction in transactions)
            {
                transaction.Display();
            }
        }

        public void GenerateReport()
        {
            decimal totalIncome = 0;
            decimal totalExpenses = 0;

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
            Console.WriteLine($"Net Balance: {totalIncome - totalExpenses}");
        }
    }