class Breathing : Activity
{
    private string breathingIn = $"\rBreath in . . .";
    private string breathingOut = $"\rBreath out . . .";
    public Breathing()
    {
        SetStarterMessage($"Welcome to the Breathing activity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }
    public override void Display(int time)
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(3);
        int t = 0;
        while (t < time)
        {
            Console.WriteLine("");
            t += TimeCounter(t,time, breathingIn);
            Console.WriteLine("");
            t +=TimeCounter(t,time, breathingOut);
            Console.WriteLine("");
        }
    }
}
