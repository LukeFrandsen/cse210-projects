using System;
public class Entry 
{
    private string entries { get; set; }// got this from AI- { get; set;}
    private string Date { get; set; }
    private string Question { get; set; }
    

    public Entry(string date, string question, string entryText)
    {
        Date = date;
        Question = question;
        entries = entryText; 
    }
    public override string ToString()
    {
        string outputString = ""; 
        outputString = $"{Date}#{Question}#{entries}";
        return outputString;
    }
}