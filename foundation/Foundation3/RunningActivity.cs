public class RunningActivity : Activity
{
    // Attributes
    private double _distance; // in km

    // Constructor
    public RunningActivity(DateTime date, double duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    // Methods
    public override string GetName()
    {
        return "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _duration) * 60;
    }
}