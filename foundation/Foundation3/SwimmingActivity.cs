public class SwimmingActivity : Activity
{
    // Attributes
    private double _laps; // number of laps, the length of a lap is 50m
    
    // Constructor
    public SwimmingActivity(DateTime date, double duration, double laps) : base(date, duration)
    {
        _laps = laps;
    }
    
    // Methods
    public override string GetName()
    {
        return "Swimming";
    }
    
    public override double GetDistance()
    {
        return 0.05 * _laps;
    }
    
    public override double GetSpeed()
    {
        return (GetDistance() / _duration) * 60;
    }
}