public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {  
    }

    // Methods
    public override void RecordEvent()
    {
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points}";
    }
}