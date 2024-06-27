using System;

public class Scripture
{
    
    private Verse _verse;

    public Scripture()
    {
        
        _verse = new Verse("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
    }
    public Verse GetVerse()
    {
        return _verse;
    }
}
