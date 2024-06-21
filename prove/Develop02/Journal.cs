using System;   
public class Journal
{
    public string Entry { get; set; }
    public string Date { get; set; }
    public string Question { get; set; }
    public List<Journal> _journal;
    public List<Journal> entries;

    public Journal(string date, string question, string entryText)
    {
        Date = date;
        Question = question;
        Entry = entryText; 

        _journal = new List<Journal>();
        entries = new List<Journal>();
    }
    public void AddEntry(string entry)
    {
        _journal.Add(new Journal(DateTime.Now.ToString("yyyy-MM-dd"), "", entry));
    }

    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Journal entry in _journal)
            {
                outputFile.WriteLine($"{entry.Date}#{entry.Question}#{entry.Entry}");
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
            _journal.Add(new Journal(date, question, entry));
        }
    }
}