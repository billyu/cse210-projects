using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        Journal journal = new Journal();

        // Loop until the user chooses to quit
        do
        {
            // Display the menu
            DisplayMenu();

            // Get the user's choice
            Console.Write("What would you like to do? ");
            input = Console.ReadLine();

            // Process the user's choice
            if (input == "1")
            {
                journal.CreateNewEntry();
            }
            else if (input == "2")
            {
                // Display the journal
                journal.DisplayAll();
            }
            else if (input == "3")
            {
                // Load the journal from a file
                Console.Write("Enter the filename to load: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if (input == "4")
            {
                // Save the journal to a file
                Console.Write("Enter the filename to save: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
            else if (input == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        } while (input != "5");
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }
}