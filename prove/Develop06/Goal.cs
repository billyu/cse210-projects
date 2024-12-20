public abstract class Goal
{
    // Attributes
    protected string _shortName;
    protected string _description;
    protected int _points;

    // Constructor
    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    // Methods
    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public string GetShortName()
    {
        return _shortName;
    }
    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}