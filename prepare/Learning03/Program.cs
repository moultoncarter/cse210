using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(5, 10);

        Console.WriteLine(fraction1.GetString());
        Console.WriteLine(fraction1.GetDouble());
        Console.WriteLine(fraction2.GetString());
        Console.WriteLine(fraction2.GetDouble());
        Console.WriteLine(fraction3.GetString());
        Console.WriteLine(fraction3.GetDouble());
    }
}