using System;

class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int num)
    {
        _numerator = num;
        _denominator = 1;
    }
    public Fraction(int num, int den)
    {
        _numerator = num;
        _denominator = den;
    }

    int GetNumerator()
    {
        return _numerator;
    }
    int GetDenominator()
    {
        return _denominator;
    }
    public string GetString()
    {
        return $"{_numerator}/{_denominator}";
    }
    public double GetDouble()
    {
        return (double)_numerator / _denominator;
    }
}