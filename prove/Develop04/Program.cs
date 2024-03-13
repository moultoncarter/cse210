using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        string[] initPrompts = {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        string[] secPrompts = {"Why was this experience meaningful to you?", "Have you ever done anything like this before?",
        "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
        string[] prompts = {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflection = new ReflectionActivity(initPrompts, secPrompts);
        ListingActivity listing = new ListingActivity(prompts);

        // Activity testAct = new Activity("Test", "Test Desc");
        // testAct.ShowInfo();
        // BreathingActivity testBreath = new BreathingActivity();
        // testBreath.ShowInfo();
        // testBreath.BeginActivity();
        // testBreath.Breathe();
        // ReflectionActivity testReflect = new ReflectionActivity();
        // testReflect.ShowInfo();
        // testReflect.BeginActivity();
        // testReflect.Reflect();
        // ListingActivity testList = new ListingActivity();
        // testList.ShowInfo();
        // testList.BeginActivity();
        // testList.List();

        string response = "";
        while (response.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n   1. Start breathing activity.\n   2. Start reflection activity.\n   3. Start listing activity.\n   4. Quit.");
            Console.WriteLine("Select a choice from the menu.");
            response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    breathing.BeginActivity();
                    breathing.Breathe();
                    break;
                case "2":
                    reflection.BeginActivity();
                    reflection.Reflect();
                    break;
                case "3":
                    listing.BeginActivity();
                    listing.List();
                    break;
                case "4":
                    response = "quit";
                    break;
            }
        }
    }
}