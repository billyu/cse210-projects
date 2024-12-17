public class ProgressiveGoal : Goal
{
    // Attributes
    private int _extraPoints;
    private int _timesRecorded;

    // Constructor
    public ProgressiveGoal(string shortName, string description, int points, int extraPoints, int timesRecorded) : base(shortName, description, points)
    {
        _extraPoints = extraPoints;
        _timesRecorded = timesRecorded;
    }

    // Methods
    public override int RecordEvent()
    {
        _timesRecorded++;
        return _points + (_timesRecorded - 1) * _extraPoints;
    }

    public override bool IsComplete()
    {
        // The goal is complete if it has been recorded at least once
        return _timesRecorded > 0;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) -- Times recorded: {_timesRecorded}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_extraPoints},{_timesRecorded}";
    }
}