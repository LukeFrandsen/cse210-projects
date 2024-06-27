using System;

public class Scripture
{
    private string _book;
    private int _chapter;
    private List<int> _verseNumbers;
    private Verse _verse;

    public Scripture()
    {
        _book = "proverbs";
        _chapter = 3;
        _verseNumbers = new List<int> {5, 6};
        _verse = new Verse("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
    }
    public Scripture(string book, int chapter, List<int> verses)
    {
        _book = book;
        _chapter = chapter;
        _verseNumbers = verses;
    }
    public Verse GetVerse()
    {
        return _verse;
    }
    public string GetReference()
    {
        return $"{_book} {_chapter}:{_verseNumbers[0]}-{_verseNumbers[1]}";
    }
}