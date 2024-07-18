class Budget
    {
        private decimal Limit { get; set; }
        private List<Expense> expenses;

        public Budget(decimal limit)
        {
            Limit = limit;
            expenses = new List<Expense>();
        }
        public decimal GetBudgetLimit()
        {
            return Limit;
        }
        public void SetBudgetLimit(decimal limit)
        {
            Limit = limit;
        }
        public void AddExpense(Expense expense)
        {
            expenses.Add(expense);
        }
        public List<Expense> GetExpenses()
        {
            return expenses;
        }
        
    }