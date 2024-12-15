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
        // Clear the console and display the starting message
        Console.Clear();
        DisplayStartingMessage();

        // Show Get Ready message
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine("\n");

        // Set end time for the activity
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        // Show Breathe In and Out message until the duration is reached
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountdown(4);
            Console.Write("\nBreathe out...");
            ShowCountdown(6);
            Console.WriteLine("\n");
        }
        
        // Show Ending message
        DisplayEndingMessage();
    }
}