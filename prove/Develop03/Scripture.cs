class Scripture
{
    private Reference _reference;
    private List<Word> _scripture;

    // Constructions
    public Scripture()
    {

    }
    public Scripture(Reference reference)
    {
        _reference = reference;
    }
    public Scripture(Reference reference, List<Word> scripture)
    {
        _reference = reference;
        _scripture = scripture;
    }

    // Modules 
    public void SetScripture(List<Word> scripture, Reference reference)
    {
        _scripture = scripture;
        _reference = reference;
    }
    public void SetScriptureText(List<Word> scripture)
    {
        _scripture = scripture;
    }
    public void SetScriptureReference(Reference reference)
    {
        _reference = reference;
    }
    public string GetScripture()
    {
        string text = "";
        foreach (Word word in _scripture)
        {
            text += word.GetWord();
            text += " ";
        }
        text = text.Trim();
        return $"{_reference.GetReference()} '{text}'";
    }
    public string GetReference()
    {
        return _reference.GetReference();
    }
    public bool Memorize()
    {
        // Create a list of int that save the indexes of the words in the scripture that are not hidden yet.
        List<int> possibleWords = new List<int>();

        // Save the indexes of the displayed words.
        for (int i = 0; i < _scripture.Count; i++)
        {
            if (_scripture[i].GetStatus())
            {
                possibleWords.Add(i);
            }
        }

        // If there are displayed words, change their status with the Hiddener method.
        if (possibleWords.Count > 3)
        {
            // Hide 3 random words.
            Hiddener(3, possibleWords);
            return false;
        }
        else if (possibleWords.Count > 0)
        {
            // Hide the remaining words.
            Hiddener(possibleWords.Count, possibleWords);
            return false;
        }
        // If all the words are hidden, return true (to finish the program).
        else
        {
            return true;
        }
    }
    private void Hiddener(int times, List<int> possibleWords)
    {
        Random random = new Random();

        // Randomly, choose a index of a non hidden word and change its status to hidden (false)
        for (int i = 0; i < times; i++)
        {
            int index = random.Next(0, possibleWords.Count);

            // Take and remove the index from the list
            int remove = possibleWords[index];
            possibleWords.RemoveAt(index);

            // Hide the random word.
            _scripture[remove].ChangeStatus();
        }
    }

}