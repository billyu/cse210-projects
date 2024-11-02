using System;

class Program
{
    static void Main(string[] args)
    {
        // In the Guess My Number game the computer picks a magic number, 
        // and then the user tries to guess it. After each guess, the computer 
        // tells the user to guess "higher" or "lower" until they guess the magic number.

        // Declare variables for magic number, guess, and response
        int magicNumber;
        int guess;
        int guessCount;
        string response;

        // Loop until user quit the game        
        do
        {
            // Generate magic number using random function
            Random randomGenerator = new Random();
            magicNumber = randomGenerator.Next(1, 101);

            Console.WriteLine("Please guess a number between 1 and 100.");

            // Reset guess count
            guessCount = 0;

            // Reset guess
            guess = -1;

            // Loop until user guesses the magic number
            while (guess != magicNumber) 
            {
                // Ask user for guess
                Console.Write("What is your guess?");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                // Check if guess is correct
                if (guess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
            }

            // Ask user if they want to play again
            Console.Write("Do you want to play again? (yes/no)");
            response = Console.ReadLine();
        } while (response == "yes");

        Console.WriteLine("Goodbye!");
    }
}