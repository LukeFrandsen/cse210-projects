public class SimpleGoal : Goal
{
    public SimpleGoal( string name, string description, int points, bool isComplete = false) : base("Simple", name, description, points, isComplete) { }
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