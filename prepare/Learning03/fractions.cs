using System.Globalization;

public class Fraction
{
    private int _topnumber;
    private int _bottumnumber;

    public Fraction()
    {
        _topnumber = 1;
        _bottumnumber = 1;
    }

    public Fraction(int top)
    {
        _topnumber = top;
        _bottumnumber = 1;
    }

    public Fraction(int top, int bottum)
    {
        _topnumber = top;
        _bottumnumber = bottum;
    }

    // public int GetTop()
    // {
    //     return _topnumber;
    // }
    // public void SetTop(int top)
    // {
    //     _topnumber = top;
    // }

    // public int GetBottum()
    // {
    //     return _bottumnumber;
    // }
    // public void SetBottum(int bottum)
    // {
    //     _bottumnumber = bottum;
    // }

    public string GetFractionString()
    {
        string fraction = $"{_topnumber}/{_bottumnumber}";
        return fraction;
    }

    // public void SetFractionString(int top, int bottum)
    // {
    //     _topnumber = top;
    //     _bottumnumber = bottum;
    // }

    public double GetDecimalValue()
    {
        return (double)_topnumber / (double)_bottumnumber;
    }


    public void Display()
    {
        Console.WriteLine($"{_topnumber}/{_bottumnumber}");
    }
}