public abstract class Activity
{
    // Attributes
    private DateTime _date;
    private int _duration;

    // Constructor
    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    // Methods
    public abstract string GetName();
    public abstract int GetDistance();
    public abstract int GetSpeed();
    public abstract int GetPace();
    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetName()} ({_duration}): Distance {GetDistance()} km, Speed {GetSpeed()} km/h, Pace {GetPace()} min/km";
    }

}