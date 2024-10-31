using System;

class Program
{
    static void Main(string[] args)
    {
        // This program determines the letter grade for a course according to the following scale:
        //      A >= 90
        //      B >= 80
        //      C >= 70
        //      D >= 60
        //      F < 60
        // Include + or - next to the letter grade according to the folowing rules:
        //      + if the last digit of the score is 7 or higher
        //      - if the last digit of the score is less than 3

        // Declare variables for score, grade, last digit and sign
        int score;
        string grade;
        int lastDigit;
        string sign;

        // Ask user for score
        Console.Write("What is your score?");
        score = Convert.ToInt32(Console.ReadLine());

        // Get the last digit of the score
        lastDigit = score % 10;

        // Determine the sign
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

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

        // There is no A+
        if (grade == "A" && sign == "+")
        {
            sign = "";
        }

        // There is no F+ or F-
        if (grade == "F")
        {
            sign = "";
        }

        // Print out the grade
        Console.WriteLine($"Your grade is {grade}{sign}.");

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