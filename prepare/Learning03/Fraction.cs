using System;

class Fraction
{
    private int _numerator;
    private int _denomenator;

    public Fraction()
    {
        _numerator = 1;
        _denomenator = 1;
    }

    public Fraction(int Num)
    {
        _numerator = Num;
        _denomenator = 1;
    }

    public Fraction(int userNum, int userDen)
    {
        _numerator = userNum;
        _denomenator = userDen;
    }

    public string GetFractionString()
    {
        string fract = $"{_numerator}/{_denomenator}";
        return fract;
    }

    public double GetDecimalVal()
    {
        return (double)_numerator / (double)_denomenator;
    }
}