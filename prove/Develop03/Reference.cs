public class Reference
{
    private string _book;
    private int _chapter;
    private List<int> _verseNumbers;

    public Reference()
    {
        _book = "proverbs";
        _chapter = 3;
        _verseNumbers = new List<int> {5, 6};
    }
    public Reference(string book, int chapter, List<int> verses)
    {
        _book = book;
        _chapter = chapter;
        _verseNumbers = verses;
    }
    public string GetReference()
    {
        return $"{_book} {_chapter}:{_verseNumbers[0]}-{_verseNumbers[1]}";
    }
}