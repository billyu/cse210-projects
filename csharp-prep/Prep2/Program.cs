using System;

class Program
{
    static void Main(string[] args)
    {
        // This program determines the letter grade for a course according to the following scale:
        // A >= 90
        // B >= 80
        // C >= 70
        // D >= 60
        // F < 60

        // Declare variables for score and grade\
        int score;
        string grade;

        // Ask user for score
        Console.Write("What is your score?");
        score = Convert.ToInt32(Console.ReadLine());

        // Determine the grade
        if (score >= 90)
        {
            grade = "A";
        }
        else if (score >= 80)
        {
            grade = "B";
        }
        else if (score >= 70)
        {
            grade = "C";
        }
        else if (score >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        // Print out the grade
        Console.WriteLine($"Your grade is {grade}.");

        // Print out a message based on the grade
        // Congratualte the student if they have at least 70, otherwise encourage them to try harder
        if (score >= 70)
        {
            Console.WriteLine("Congratulations!");
        }
        else
        {
            Console.WriteLine("You can do better!");
        }
    }
}