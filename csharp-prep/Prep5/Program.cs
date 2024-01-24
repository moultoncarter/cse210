using System;

class Program
{   
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name.");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number.");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    static int SquareNumber(int num)
    {
        int sqNum = num * num;
        return sqNum;

    }
    static void DisplayResult(string name, int num)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {num}");
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int sqNum = SquareNumber(num);
        DisplayResult(name, sqNum);
    }
}