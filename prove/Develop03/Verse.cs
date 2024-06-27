using System;
using System.Security.Cryptography.X509Certificates;

public class Verse
{
    private List<Word> words = new List<Word>();
    private List<int> shownWordIndexes = new List<int>();
    public Verse(string verse)
    {
        string[] text = verse.Split(' ');
        foreach (string word in text)
        {
            words.Add(new Word(word));
        }
        for (int i = 0; i < words.Count; i++)
            {
                if (!words[i].getIsHidden())
                {
                    shownWordIndexes.Add(i);
                }
            }
    }
    public void DisplayVerse()
    {
        string verse = "";
        foreach (Word word in words)
        {   
            if(word.getIsHidden())
            {
                for (int i = 0; i < word.getText().Count(); i++)
                {
                    verse += "_";
                }
                verse += " ";
            }
            else
            {
                verse += word.getText() + " ";
            }
        }
        Console.WriteLine(verse);
    }

    public void hideWords(){
        int count = 0;
        while(count < 3)
        {
            shownWordIndexes.Clear();
            for (int i = 0; i < words.Count; i++)
            {
                if (!words[i].getIsHidden())
                {
                    shownWordIndexes.Add(i);
                }
            }
            Random random = new Random();
            int randomIndex = random.Next(0, shownWordIndexes.Count);
            if (randomIndex >= 0)
            {
               words[shownWordIndexes[randomIndex]].setIsHidden(true);
            }
            
            ++count;
            
        }
        
    }
    public int GetCount()
    {
        return shownWordIndexes.Count;
    }
}

    