abstract class Transaction
    {
        public decimal Amount { get; protected set; }
        public string Description { get; protected set; }
        public DateTime Date { get; protected set; }

        public Transaction(decimal amount, string description, DateTime date)
        {
            Amount = amount;
            Description = description;
            Date = date;
        }

        public abstract void Display();
    }