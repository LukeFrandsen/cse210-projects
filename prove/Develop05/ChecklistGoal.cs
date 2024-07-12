public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public int TargetCount
    {
        get => _targetCount;
        private set => _targetCount = value;
    }

    public int CurrentCount
    {
        get => _currentCount;
        private set => _currentCount = value;
    }

    public int BonusPoints
    {
        get => _bonusPoints;
        private set => _bonusPoints = value;
    }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints, bool isComplete = false)
        : base("Checklist", name,description, points, isComplete)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        CurrentCount++;
        if (CurrentCount >= TargetCount)
        {
            IsComplete = true;
            return Points + BonusPoints;
        }
        return Points;
    }

    public override string GetGoalStatus()
    {
        return IsComplete ? "[X] Completed" : $"[ ] Completed {CurrentCount}/{TargetCount} times";
    }
}