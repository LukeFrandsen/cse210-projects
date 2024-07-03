class Activity
{
    private string _starterMessage;
    private string _description;
    private string _endMessage;
    private string _messageDuration;
    private int _timeDuration;
    private List<string> spinner = new List<string> {"/", "-", "\\", "|"};

    public Activity()
    {
        _endMessage = "Well Done!!";
        _timeDuration = 10;
        _messageDuration = $"How long (in seconds) do you want to do this activity? ";
    }
    public int GetTimeDuration()
    {
        return _timeDuration;
    }
    public void SetTimeDuration(int time)
    {
        _timeDuration = time;
    }
    public string GetStarterMessage()
    {
        return _starterMessage;
    }
    public void SetStarterMessage(string startMessage)
    {
        _starterMessage = startMessage;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetEndMessage()
    {
        return _endMessage;
    }
    public string GetMessegeDuration()
    {
        return  _messageDuration;
    }
    public void Spinner(int time)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }
    public void Timer()
    {
        for (int i = GetTimeDuration(); i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b \b");
        }
    }
    public int CountDown(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b \b");
        }
        return time;
    }
    public int TimeCounter(int t, int time,string str = "\r" ,int loopCount = 5){

        for (int i = loopCount; i > 0; i--)
            {
                if (str != "\r")
                {
                    Console.Write(str + i);
                }
                Thread.Sleep(1000); // Pause for 1 second
                t++;
                Console.Write("\b \b");
                if (t >= time)
                {
                    break;
                }
            }
        return t;
    }
    public virtual void Display(int time)
    {

    }

    public void RandomPrompt(List<string> prompts)
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(prompts.Count);
        Console.WriteLine(prompts[randomIndex]);
    }
    public void DisplayStart()
    {
        Console.Clear();
        Console.WriteLine(GetStarterMessage());
        Console.WriteLine();
        Console.WriteLine(GetDescription());
        Console.WriteLine();
        Console.Write(GetMessegeDuration());
        int time = Convert.ToInt32(Console.ReadLine());
        Spinner(3);
        Display(time);
        Console.WriteLine(GetEndMessage());
        Spinner(3);
        Console.WriteLine($"You have complete another {time} seconds of this activity");
        Spinner(3);
        
    }

}