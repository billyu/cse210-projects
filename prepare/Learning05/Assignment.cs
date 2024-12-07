public class Assignment
{
    // Attributes
    protected string _studentName;
    protected string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Methods
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}