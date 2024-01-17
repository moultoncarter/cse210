using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade?");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);

        string letterGrade = "";
        if (gradeInt >= 90)
        {
            letterGrade = "A";
        } 
        else if (gradeInt >= 80)
        {
            letterGrade = "B";
        }
        else if (gradeInt >= 70)
        {
            letterGrade = "C";
        }
        else if (gradeInt >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your grade is {letterGrade}.");
        if (gradeInt >= 70)
        {
            Console.WriteLine("You passed. Congratulations!");
        }
        else 
        {
            Console.WriteLine("You failed. Better luck next time!");
        }

    }
}