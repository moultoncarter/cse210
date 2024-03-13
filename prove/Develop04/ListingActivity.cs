public class ListingActivity : Activity
{
    string[] _prompts;
    public ListingActivity(string[] prompts) : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain length of time.")
    {
        _prompts = prompts;
    }

    public void List()
    {
        IncreaseTotal(_duration);
        int items = 0;
        Random rand = new Random();
        int usedPrompt = rand.Next(0, _prompts.Length-1);
        Console.Clear();
        Console.WriteLine(_prompts[usedPrompt]);
        Spinner(5);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            items++;
        }
        Console.WriteLine($"You listed {items} items!");
        Finish(_duration);
    }
}