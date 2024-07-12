public abstract class Goal
{
    private string _type { get; set; }
    private string _name { get; set; }
    private string _description { get; set; }
    private int _points { get; set; }
    private bool _isComplete { get; set; }
    public Goal(string type, string name, string description, int points, bool isComplete = false)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }
    public string Type
    {
        get => _type;
        protected set => _type = value;
    }
    public string Name
    {
        get => _name;
        protected set => _name = value;
    }
    public string Description
    {
        get => _description;
        protected set => _description = value;
    }

    public int Points
    {
        get => _points;
        protected set => _points = value;
    }

    public bool IsComplete
    {
        get => _isComplete;
        protected set => _isComplete = value;
    }
    public abstract int RecordEvent();
    public abstract string GetGoalStatus();
}