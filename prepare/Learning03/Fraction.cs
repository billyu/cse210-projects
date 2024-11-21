public class Fraction
{
    private int _top;
    private int _bottom;

    // Default constructor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with whole number
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor with top and bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for _top
    public int GetTop()
    {
        return _top;
    }

    // Setter for _top
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for _bottom
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for _bottom
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Generate a string representation of the fraction
    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }

    // Generate a decimal representation of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
