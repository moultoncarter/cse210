public class ReflectionActivity : Activity
{
    private string[] _initialPrompts;
    private string[] _secondaryPrompts;
    public ReflectionActivity(string[] initPrompts, string[] secPrompts) : base("Reflection Activity", @"This activity will help you reflect on times in your life when you have shown strength and resilience. 
This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _initialPrompts = initPrompts;
        _secondaryPrompts = secPrompts;
    }

    public void Reflect()
    {
        IncreaseTotal(_duration);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Random rand = new Random();
        int usedInitial = rand.Next(0, _initialPrompts.Length-1);
        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine(_initialPrompts[usedInitial]);
            int usedSecondary = rand.Next(0, _secondaryPrompts.Length-1);
            Console.WriteLine(_secondaryPrompts[usedSecondary]);
            Spinner(5);
        }
        Finish(_duration);
    }
}