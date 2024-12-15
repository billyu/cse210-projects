public abstract class Shape
{
    // Attributes
    private string _color;

    // Getter and Setter
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // Abstract method
    public abstract double GetArea();
}