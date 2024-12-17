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
                    Console.WriteLine("Invalid input.");
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
        // Display goal names
        Console.WriteLine("The goals are: ");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetShortName()}");
            index++;
        }
    }

    private void ListGoalDetails()
    {
        // Display goal details
        Console.WriteLine("The goals are: ");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            string status = goal.IsComplete() ? "X" : " ";
            Console.WriteLine($"{index}. [{status}] {goal.GetDetailsString()}");
            index++;
        }
    }

    private void CreateGoal()
    {
        // Display goal types
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Chekclist Goal");
        Console.WriteLine("  4. Progressive Goal");

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
            case "4":
                CreateProgressiveGoal();
                break;
            default:
                Console.WriteLine("Invalid input.");
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

    private void CreateProgressiveGoal()
    {
        // Ask user for goal details
        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points assoicated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("What is the extra points for each time the goal is recorded? ");
        int extraPoints = int.Parse(Console.ReadLine());

        // Create goal
        Goal goal = new ProgressiveGoal(shortName, description, points, extraPoints, 0);

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
        Goal goal = new CheckListGoal(shortName, description, points, bonus, target, 0);

        // Add goal to list
        _goals.Add(goal);
    }

    private void RecordEvent()
    {
        // Display goal names
        ListGoalNames();

        // Ask user for goal index
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        // Record event
        int pointsEarned = _goals[index].RecordEvent();
        _score += pointsEarned;

        // Display points earned
        Console.WriteLine($"\nCongratulations! You have earned {pointsEarned} points.");
    }

    private void SaveGoals()
    {
        // Ask user for file name
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        // Open file for writing
        using (StreamWriter writer = new StreamWriter(filename))
        {
            // First line is the score
            writer.WriteLine(_score);

            // Write each goal to the file
            foreach (Goal goal in _goals)
            {
                // Determine the type of goal and save the name to a variable
                string goalType;
                if (goal is SimpleGoal)
                {
                    goalType = "SimpleGoal";
                }
                else if (goal is EternalGoal)
                {
                    goalType = "EternalGoal";
                }
                else if (goal is CheckListGoal)
                {
                    goalType = "CheckListGoal";
                }
                else if (goal is ProgressiveGoal)
                {
                    goalType = "ProgressiveGoal";
                }
                else
                {
                    goalType = "UnknownGoal";
                }

                // Write the goal to the file
                // Goal Type and Goal Details are separated by a colon

                writer.WriteLine($"{goalType}:{goal.GetStringRepresentation()}");
            }
        }
    }

    private void LoadGoals()
    {
        // Ask user for file name
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        // Clear current goals
        _goals.Clear();

        // Open file for reading
        using (StreamReader reader = new StreamReader(filename))
        {
            // Read the score
            _score = int.Parse(reader.ReadLine());

            // Read each goal from the file
            while (!reader.EndOfStream)
            {
                // Read the goal line
                string goalLine = reader.ReadLine();

                // Split the goal line into parts
                string[] parts = goalLine.Split(new char[]{ ':', ','});

                // Determine the type of goal
                Goal goal;
                switch (parts[0])
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                        break;
                    case "CheckListGoal":
                        goal = new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                        break;
                    case "ProgressiveGoal":
                        goal = new ProgressiveGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                        break;
                    default:
                        goal = null;
                        break;
                }

                // Add goal to list
                _goals.Add(goal);
            }
        }
    }
}