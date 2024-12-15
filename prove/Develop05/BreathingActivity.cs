public class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    // Methods
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        ShowSpinner(_duration);
        DisplayEndingMessage();
    }
}