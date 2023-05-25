class Word
{
    private string _word;
    private bool _status;

    // Constructions
    public Word ()
    {
        _status = true;
    }
    public Word (string word, bool status)
    {
        _word = word;
        _status = status;
    }
    public Word (string word)
    {
        _word = word;
        _status = true;
    }

    // Modules
    public string Transform(){
        string underscores = "";
        for (int i = 0; i < _word.Length; i++){
            underscores += "_";
        }
        return underscores;
    }
    public void SetWord (string word){
        _word = word;
    }
    public string GetWord(){
        if (_status == true){
            return _word;
        }
        else {
            string underscores = Transform();
            return underscores;
        }
    }
    public bool GetStatus(){
        return _status;
    }
    public void ChangeStatus(){
        if (_status == true){
            _status = false;
        }
        else {
            _status = true;
        }
    }
}