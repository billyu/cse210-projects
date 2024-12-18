public class CyclingActivity : Activity
{
    // Attributes
    private double _speed; // in km/h

    // Constructor
    public CyclingActivity(DateTime date, double duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    // Methods
    public override string GetName()
    {
        return "Cycling";
    }

    public override double GetDistance()
    {
        return _speed * (_duration / 60);
    }

    public override double GetSpeed()
    {
        return _speed;
    }
}