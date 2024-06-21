using System;   
public class Journal
{
    private List<string> prompt;
    private Random rng;
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
        rng = new Random();
        prompt = 
        ["Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?", 
        "How did I see the hand of the Lord in my life today?", 
        "What was the strongest emotion I felt today?", 
        "If I had one thing I could do over today, what would it be?"];
    }
    public void AddEntry(string question, string entry)
    {
        entries.Add(new Entry(DateTime.Now.ToString("yyyy-MM-dd"), question, entry));
    }
    public string RandomPrompt()
    {
        int index = rng.Next(prompt.Count);
        return (prompt[index]);
    }
    public void DisplayEntries()
{
    foreach (Entry entry in entries)
    {
        Console.WriteLine(entry);
    }
}
    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
               outputFile.WriteLine(entry.ToString());
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('#');
            string date = parts[0];
            string question = parts[1];
            string entry = parts[2];
            entries.Add(new Entry(date, question, entry));
            Entry entry1 = new Entry(date, question, entry);
            entries.Add(new Entry(date, question, entry));
            

        }
    }
}