public class ReflectingActivity : Activity
{
    // Attributes
    private List<string> _prompts;
    private List<string> _questions;
    private int _questionsLeft;

    // Constructor
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string> { "Think of a time when you stood up for someone else.", 
                                      "Think of a time when you did something really difficult.", 
                                      "Think of a time when you helped someone in need.", 
                                      "Think of a time when you did something truly selfless." };
        _questions = new List<string> { "Why was this experience meaningful to you?", 
                                        "Have you ever done anything like this before?", 
                                        "How did you get started?", 
                                        "How did you feel when it was complete?", 
                                        "What made this time different than other times when you were not as successful?",
                                        "What is your favorite thing about this experience?",
                                        "What could you learn from this experience that applies to other situations?",
                                        "What did you learn about yourself through this experience?", 
                                        "How can you keep this experience in mind in the future?" };
        _questionsLeft = _questions.Count;
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
        DisplayPrompt();

        // Ask user to get ready to answer questions
        Console.WriteLine("Now, ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(4);

        // Display a random question from the list _questions
        DisplayQuestions();
        
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

    public string GetRandomQuestion()
    {
        // If there are no questions left, reset _questionsLeft to the number of questions in the list _questions
        if (_questionsLeft == 0)
        {
            _questionsLeft = _questions.Count;
        }

        // Get a random question from the list _questions
        Random random = new Random();
        int index = random.Next(_questionsLeft);
        string nextQuestion = _questions[index];

        // Swap the question with the last question in the list
        _questions[index] = _questions[_questionsLeft - 1];
        _questions[_questionsLeft - 1] = nextQuestion;

        // Decrement the number of questions left
        _questionsLeft--;

        // Return the random question
        return nextQuestion;
    }

    public void DisplayPrompt()
    {
        // Display a random prompt from the list _prompts
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {GetRandomPrompt()} ---\n");

        // Wait for user to press enter
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        Console.Clear();

        // Set end time for the activity
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        // Show random question from the list _questions until the duration is reached
        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(5);
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}