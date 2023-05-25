class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;

    // Constructions
    public Reference (string book, int chapter, int firstVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }
    public Reference (string book, int chapter, int firstVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = 0;
    }
    public Reference ()
    {
        _lastVerse = 0;
    }

    // Modules
    public string GetReference (){
        if (_lastVerse != 0){
            return $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
        }
        else {
            return $"{_book} {_chapter}:{_firstVerse}";
        }
    }
    public void SetReference (string book, int chapter, int firstVerse, int lastVerse = 0){
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }
}