using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numList = new List<int>();
        int newNum = -1;

        while (newNum != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            newNum = int.Parse(Console.ReadLine());
            if (newNum == 0)
            {
                break;
            }
            numList.Add(newNum);
        }
        Console.WriteLine($"Your list is: {string.Join(", ", numList)}.");

        int sum = 0;
        int iter = 0;
        float avg;
        int highest = 0;
        foreach (int number in numList)
        {
            if (number > highest)
            {
                highest = number;
            }
            sum += number;
            iter++;
        }
        avg = sum / iter;

        Console.WriteLine($"The sum is: {sum}.");
        Console.WriteLine($"The average is: {avg}.");
        Console.WriteLine($"The highest number is: {highest}.");


    }
}