public class Activity
{
    // Attributes
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructor
    public Activity()
    {
    }

    // Methods
    public void DisplayStartingMessage()
    {
        Console.Clear();

        // Display name and description of the activity
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");

        // Ask user for the duration of the activity
        Console.Write("How long, in seconds, would you like for this session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string spinner = "-\\|/";

        for (int i = 0; i < seconds; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(spinner[j]);
                Thread.Sleep(250);
                Console.Write("\b");
            }
            Console.Write(" \b");
        }
    }

    public void ShowCountdown(int seconds)
    {
        if (seconds <= 0 || seconds >= 10)
        {
            return;
        }

        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}