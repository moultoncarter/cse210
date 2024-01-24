using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random ranGen = new Random();
        int mNumber = ranGen.Next(1, 100);
        Console.WriteLine("Please guess a number between 1 and 100.");
        int guess = int.Parse(Console.ReadLine());
        /* using a for loop just because its simple and lets me use i for the # of tries
        i doubt itll take them more than 100 tries to guess a potential 100 numbers */
        for (int i = 0; i < 100; i++)
        {
            if (guess > 100 || guess < 1)
            {
                break;
            }
            if (guess == mNumber)
            {
                Console.WriteLine("You guessed the number!");
                Console.WriteLine($"You guessed the number in {i} tries!");
                break;
            } else if (guess <= mNumber)
            {
                Console.WriteLine("The number is higher than your guess.");
            } else
            {
                Console.WriteLine("The number is lower than your guess.");
            }

            Console.WriteLine("Please guess a number between 1 and 100.");
            guess = int.Parse(Console.ReadLine());
        }
    }
}