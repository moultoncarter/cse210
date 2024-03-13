public class Activity
{
    private string _name;
    private string _description;
    protected int _duration = 0;
    private int _total = 0;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    //actually only shows name, description, and prompts duration
    public void BeginActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine($"\n{_description}");
        Console.WriteLine("\nHow long do you want this activity to last? (Please enter the time in seconds)");
        _duration = int.Parse(Console.ReadLine());
    }

    protected void Finish(int duration)
    {
        Console.WriteLine($"\nWell done!\n\nYou have completed {duration} seconds of the {_name} activity.\nYou have spent a total of {_total} seconds on this activity.\n\nPress enter to continue.");
        Console.ReadLine();
    }

    protected void IncreaseTotal(int increase)
    {
        _total += increase;
    }

    protected void Spinner(int duration)
    {
        char[] spinnerParts = {'|', '/', '—', '\\'};
        int x = 0;
        int y = 0;
        while (y != duration * 4)
        {
            y++;
            if (x == 3){
                x = 0;
            }
            Console.Write(spinnerParts[x]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            x++;
        }
    }

    //debug
    public void ShowInfo()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_description);
        Console.WriteLine(_duration);
        Console.WriteLine(_total);
    }
}