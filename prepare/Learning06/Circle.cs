public class Circle : Shape
{
    // Attributes
    private double _radius;

    // Constructor
    public Circle(double radius)
    {
        _radius = radius;
    }

    // Getter and Setter
    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    // Implement abstract method
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}