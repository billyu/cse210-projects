using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment Test
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");

        Console.WriteLine(assignment1.GetSummary());

        // MathAssignment Test
        MathAssignment assignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.2", "8-19");

        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        // WritingAssignment Test
        WritingAssignment assignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");

        Console.WriteLine(assignment3.GetWritingInformation());
    }
}