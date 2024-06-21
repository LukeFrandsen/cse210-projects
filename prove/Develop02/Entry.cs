using System;
public class Entry 
{
    public string entries { get; set; }
    public string Date { get; set; }
    public string Question { get; set; }
    

    public Entry(string date, string question, string entryText)
    {
        Date = date;
        Question = question;
        entries = entryText; 
    }
    public override string ToString()
    {
        string outputString = ""; // Declare the outputString variable
        outputString = $"{Date}#{Question}#{entries}";
        return outputString;
    }
}