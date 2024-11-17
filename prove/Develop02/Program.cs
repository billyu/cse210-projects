using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

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
                // Write a new entry
                // variables
                DateTime date = DateTime.Now;
                string promptText = promptGenerator.GetRandomPrompt();
                string entryText = "";

                // Get the user's response
                Console.WriteLine(promptText);
                Console.Write("> ");
                entryText = Console.ReadLine();
                
                // Create a new entry
                Entry newEntry = new Entry(date, promptText, entryText);
                journal.AddEntry(newEntry);

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