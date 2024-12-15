public class Square : Shape
{
    // Attributes
    private double _side;

    // Constructor
    public Square(double side)
    {
        _side = side;
    }

    // Getter and Setter
    public double GetSide()
    {
        return _side;
    }

    public void SetSide(double side)
    {
        _side = side;
    }

    // Implement abstract method
    public override double GetArea()
    {
        return _side * _side;
    }
}   