public class ListingActivity : Activity
{
    // Attributes
    private int _count;
    private List<string> _prompts;

    // Constructor
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 5;
        _prompts = new List<string> { "Who are people that you appreciate?", 
                                      "What are personal strengths of yours?", 
                                      "Who are people that you have helped this week?", 
                                      "When have you felt the Holy Ghost this month?", 
                                      "Who are some of your personal heroes?" };
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

        // Display a random prompt from the list _prompts
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");

        Console.Write("You may begin in: ");
        ShowCountdown(4);
        Console.WriteLine();

        // Get user responses
        List<string> userResponses = GetListFromUser();
        Console.WriteLine($"You listed {_count} items!\n");
        
        // Show Ending message
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        // Get a random prompt from the list _prompts
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        // Set end time for the activity
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        // Get user responses until the duration is reached
        List<string> userResponses = new List<string>();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            userResponses.Add(response);
        }

        _count = userResponses.Count;

        return userResponses;
    }
}