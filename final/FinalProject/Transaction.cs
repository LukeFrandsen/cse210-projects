abstract class Transaction
    {
        protected decimal Amount { get; set; }
        protected string Description { get; set; }
        protected DateTime Date { get; set; }

        public Transaction(decimal amount, string description, DateTime date)
        {
            Amount = amount;
            Description = description;
            Date = date;
        }
        public decimal GetAmount()
        {
            return Amount;
        }
        public abstract void Display();
    }