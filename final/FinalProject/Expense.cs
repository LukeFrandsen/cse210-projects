class Expense : Transaction
    {
        public Expense(decimal amount, string description, DateTime date)
            : base(amount, description, date)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"Expense: {Description}, Amount: {Amount}, Date: {Date.ToShortDateString()}");
        }
    }