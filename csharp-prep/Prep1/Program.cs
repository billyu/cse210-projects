using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare variables for first name and last name
        string firstName;
        string lastName;

        // Ask user for first name
        Console.Write("What is your first name?");
        firstName = Console.ReadLine();

        // Ask user for last name
        Console.Write("What is your last name?");
        lastName = Console.ReadLine();

        // Print out the full name using string interpolation
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}