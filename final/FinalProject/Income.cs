class Income : Transaction
    {
        public Income(decimal amount, string description, DateTime date)
            : base(amount, description, date)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"Income: {Description}, Amount: {Amount}, Date: {Date.ToShortDateString()}");
        }
    }
