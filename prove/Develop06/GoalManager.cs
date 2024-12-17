public class GoalManager
{
    // Attributes
    private List<Goal> _goals;
    int _score;

    // Constructor
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // Methods
    public void Start()
    {
        // Loop until user quits
        while (true)
        {
            // Display player information
            DisplayPlayerInfo();

            // Display menu
            DisplayMenu();

            // Get user input
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            // Process user input
            switch (input)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }

            // Add a blank line for spacing
            Console.WriteLine();
        }
    }

    private void DisplayMenu()
    {
        // Display menu options
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
    }

    private void DisplayPlayerInfo()
    {
        // Display player information
        Console.WriteLine($"You have {_score} points.\n");
    }

    private void ListGoalNames()
    {
    }

    private void ListGoalDetails()
    {
    }

    private void CreateGoal()
    {
    }

    private void RecordEvent()
    {
    }

    private void SaveGoals()
    {
    }

    private void LoadGoals()
    {
    }
}