public abstract class Activity
{
    // Attributes
    protected DateTime _date;
    protected double _duration;  // in minutes

    // Constructor
    public Activity(DateTime date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    // Methods
    public abstract string GetName();
    public abstract double GetDistance();
    public abstract double GetSpeed();
    
    public virtual double GetPace()
    {
        return 60 / GetSpeed();
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetName()} ({_duration}): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} km/h, Pace {GetPace():F2} min/km";
    }
}