public class CheckListGoal : Goal
{
    // Attributes
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor
    public CheckListGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Methods
    public override void RecordEvent()
    {
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}