using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0. 

        // Declare variables for number and list
        int number;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a series of numbers. Enter 0 to stop.");
        
        // Loop until user enters 0
        do
        {
            // Ask user for number
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            // Add number to list if it is not 0
            if (number != 0)
            {
                numbers.Add(number);
            }
                        
        } while (number != 0);

        // Compute the sum of the numbers in the list
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum of the numbers is {sum}.");

        // Compute the average of the numbers in the list
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers is {average}.");

        // Compute the maximum of the numbers in the list
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The maximum of the numbers is {max}.");

        // Find the smallest positive number in the list
        int minPositive = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > 0 && num < minPositive)
            {
                minPositive = num;
            }
        }
        if (minPositive == int.MaxValue)
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is {minPositive}.");
        }

        // Sort the list in ascending order
        numbers.Sort();
        Console.Write("The numbers in ascending order are: ");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}