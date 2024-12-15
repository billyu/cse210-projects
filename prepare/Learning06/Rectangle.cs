public class Rectangle : Shape
{
    // Attributes
    private double _width;
    private double _length;

    // Constructor
    public Rectangle(double width, double length)
    {
        _width = width;
        _length = length;
    }

    // Getter and Setter
    public double GetWidth()
    {
        return _width;
    }

    public void SetWidth(double width)
    {
        _width = width;
    }

    public double GetLength()
    {
        return _length;
    }

    public void SetLength(double length)
    {
        _length = length;
    }

    // Implement abstract method
    public override double GetArea()
    {
        return _width * _length;
    }
}