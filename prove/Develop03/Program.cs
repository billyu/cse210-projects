using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Scriptures object
        Scriptures myScriptures = new Scriptures();
        Scripture scripture = myScriptures.GetRandomScripture();
        
        // Display the original text
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        while (true) {
            // Prompt the user to continue or quit
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            if (input == "quit" || scripture.IsCompletelyHidden()) {
                break;
            }

            // Clear the console
            Console.Clear();

            // Hide three random words
            scripture.HideRandomWords(3);

            // Display the text with hidden words
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}