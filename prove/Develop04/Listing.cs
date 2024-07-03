class Listing : Activity
{
  
    private List<string> _prompts;

    public Listing()
    {
        SetStarterMessage ("Welcome to the Listing activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        _prompts = new List<string> 
        {"Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"};
    }
    public override void Display(int time)
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Spinner(3);
        Console.WriteLine("List as many resonses as you can for the following promt:");
        RandomPrompt(_prompts);
        Console.WriteLine("You may begin in . . .");
        CountDown(3);
        Console.WriteLine("Go!");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
        }

        // int t = 0;
        // while(t<time)
        // {
            
        //     List<string> responses = new List<string>();
        //     responses.Add(Console.ReadLine());
        // }
        // List<string> responses = new List<string>();
        // responses.Add();

    }
}