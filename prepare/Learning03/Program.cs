using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a fraction with the default constructor
        Fraction defaultFraction = new Fraction();
        DisplayFraction(defaultFraction);

        // Create a fraction with a whole number 5
        Fraction wholeNumberFraction = new Fraction(5);
        DisplayFraction(wholeNumberFraction);

        // Create a fraction with 3/4
        Fraction fraction = new Fraction(3, 4);
        DisplayFraction(fraction);

        // Create a fraction with 1/3
        Fraction fraction2 = new Fraction(1, 3);
        DisplayFraction(fraction2);
    }

    static void DisplayFraction(Fraction fraction)
    {
        // Display the fraction string
        Console.WriteLine(fraction.GetFractionString());
        // Display the decimal value
        Console.WriteLine(fraction.GetDecimalValue());
    }
}