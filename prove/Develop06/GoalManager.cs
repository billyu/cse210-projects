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
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
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
        // Display goal types
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Chekclist Goal");

        // Ask user for goal type
        Console.Write("Which type of goal would you like to create? ");
        string input = Console.ReadLine();

        // Process user input
        switch (input)
        {
            case "1":
                CreateSimpleGoal();
                break;
            case "2":
                CreateEternalGoal();
                break;
            case "3":
                CreateChecklistGoal();
                break;
            default:
                Console.WriteLine("Invalid input. Please try again.");
                break;
        }
    }

    private void CreateSimpleGoal()
    {
        // Ask user for goal details
        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points assoicated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        // Create goal
        Goal goal = new SimpleGoal(shortName, description, points);

        // Add goal to list
        _goals.Add(goal);
    }

    private void CreateEternalGoal()
    {
        // Ask user for goal details
        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points assoicated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        // Create goal
        Goal goal = new EternalGoal(shortName, description, points);

        // Add goal to list
        _goals.Add(goal);
    }

    private void CreateChecklistGoal()
    {
        // Ask user for goal details
        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points assoicated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonus = int.Parse(Console.ReadLine());

        // Create goal
        Goal goal = new CheckListGoal(shortName, description, points, target, bonus);
        
        // Add goal to list
        _goals.Add(goal);
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