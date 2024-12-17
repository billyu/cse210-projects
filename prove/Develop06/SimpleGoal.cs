public class SimpleGoal : Goal
{
    // Attributes
    private bool _isComplete;

    // Constructor
    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isComplete = false;
    }

    // Methods
    public override void RecordEvent()
    {
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_isComplete}";
    }
}