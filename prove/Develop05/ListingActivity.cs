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
    }

    public string GetRandomPrompt()
    {
        return "Default prompt";
    }

    public List<string> GetListFromUser()
    {
        return null;
    }
}