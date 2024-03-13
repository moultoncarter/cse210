public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", @"This activity will help you relax by walking you through breathing in and out slowly. 
Clear your mind and focus on your breathing."){}

    public void Breathe()
    {
        IncreaseTotal(_duration);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        bool inOrOut = false;
        while (DateTime.Now < endTime)
        {
            Console.Clear();
            if (inOrOut)
            {
                inOrOut = false;
                Console.Write("Breathe out...");
            } else
            {
                inOrOut = true;
                Console.Write("Breathe in...");
            }
            Spinner(4);
        }
        Finish(_duration);
    }
}