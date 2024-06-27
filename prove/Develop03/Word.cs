using System;

public class Word
{
    private string text;
    private bool isHidden;
    public Word(string text)
    {
        this.text = text;
        this.isHidden = false;
    }
    public string getText()
    {
        return text;
    }
    public void setText(string text)
    {
        this.text = text;
    }
    public bool getIsHidden()
    {
        return isHidden;
    }
    public void setIsHidden(bool isHidden)
    {
        this.isHidden = isHidden;
    }
}