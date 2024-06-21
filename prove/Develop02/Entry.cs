using System;
public class Entry 
{
    private List<string> prompt;
    private Random rng;

    public Entry()
    {
        rng = new Random();
        prompt = 
        ["Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?", 
        "How did I see the hand of the Lord in my life today?", 
        "What was the strongest emotion I felt today?", 
        "If I had one thing I could do over today, what would it be?"];
    }
    public void RandomPrompt()
    {
        int index = rng.Next(prompt.Count);
        Console.WriteLine(prompt[index]);
    }
}