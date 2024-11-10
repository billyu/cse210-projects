using System;

class Program
{
    // In this program, there are several functions:

    // DisplayWelcome - Displays the message, "Welcome to the Program!"
    // PromptUserName - Asks for and returns the user's name (as a string)
    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    // DisplayResult - Accepts the user's name and the squared number and displays them.

    // Main function should then call each of these functions saving the return values and passing data to them as necessary.

    static void Main(string[] args)
    {
        // Delcare variables for name, number, and squared number
        String name;
        int number;
        int squaredNumber;

        // Call each function
        DisplayWelcome();
        name = PromptUserName();
        number = PromptUserNumber();
        squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"Hi {name}, The square of your number is {number}.");
    }
}