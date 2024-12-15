using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        // Create square object
        Square square = new Square(5);
        square.SetColor("Red");
        shapes.Add(square);

        // Create rectangle object
        Rectangle rectangle = new Rectangle(5, 10);
        rectangle.SetColor("Blue");
        shapes.Add(rectangle);

        // Create circle object
        Circle circle = new Circle(5);
        circle.SetColor("Green");
        shapes.Add(circle);

        // Print area of each shape
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area of {shape.GetColor()} shape is {shape.GetArea()}.");
        }
    }
}