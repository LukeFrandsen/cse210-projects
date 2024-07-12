public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, bool isComplete = false) : base("Eternal", name, description, points, isComplete) { }

    public override int RecordEvent()
    {
        IsComplete = true;
        return Points;
    }

    public override string GetGoalStatus()
    {
        return IsComplete ? "[X]" : "[ ]";
    }
}