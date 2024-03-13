using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment testAssignment = new Assignment("Samuel Bennett", "Multiplication");
        MathAssignment testMath = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        WritingAssignment testWriting = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(testAssignment.GetSummary());
        Console.WriteLine(testMath.GetSummary());
        Console.WriteLine(testMath.GetHomeworkList());
        Console.WriteLine(testWriting.GetSummary());
        Console.WriteLine(testWriting.GetWritingInformation());
    }
}