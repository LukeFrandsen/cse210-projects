 class SavingsGoal
    {
        private decimal GoalAmount { get; set; }
        private decimal CurrentAmount { get; set; }

        public SavingsGoal(decimal goalAmount)
        {
            GoalAmount = goalAmount;
            CurrentAmount = 0;
        }

        public void AddSavings(decimal amount)
        {
            CurrentAmount += amount;
        }

        public bool IsGoalMet()
        {
            return CurrentAmount >= GoalAmount;
        }
    }