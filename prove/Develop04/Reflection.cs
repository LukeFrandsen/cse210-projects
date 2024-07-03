using System.CodeDom.Compiler;

class Reflection : Activity
{
    
    private List<string> _prompts;
    private List<string> _questions;
    private string _consider;

    public Reflection()
    {
        SetStarterMessage("Welcome to the Reflection activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        _prompts = new List<string> 
        {"Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."};
        _questions = new List<string> 
        {"Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"};   
        _consider = "Now consider the following questions:\n You may begin in...";
    }
    public void DisplayPrompts()
    {
        RandomPrompt(_prompts);
    }
    public void DisplayQuestions()
    {
        RandomPrompt(_questions);
    }
    public override void Display(int time)
    {
        Console.Clear();
        Console.WriteLine($"Get Ready...\r");
        Spinner(3);
        Console.WriteLine("Consider the following Prompt:");
        Console.WriteLine("");
        DisplayPrompts();
        Console.WriteLine("When you have somthing in mind press Enter to continue:");
        string next = Console.ReadLine();
        Console.WriteLine(_consider);
        int t = 0;
        if (next == "")
        {
            while(t<time)
            {    
                t += TimeCounter(t,time, str: "", loopCount: 5);
                Console.Clear();
                DisplayQuestions();
            }

        }
    }

}