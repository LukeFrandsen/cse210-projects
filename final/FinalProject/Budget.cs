class Budget
    {
        private decimal Limit { get; set; }
        private List<Expense> expenses;

        public Budget(decimal limit)
        {
            Limit = limit;
            expenses = new List<Expense>();
        }

        public void AddExpense(Expense expense)
        {
            expenses.Add(expense);
        }

        public bool IsWithinBudget()
        {
            decimal totalExpenses = 0;

            foreach (var expense in expenses)
            {
                totalExpenses += expense.Amount;
            }

            return totalExpenses <= Limit;
        }
    }