using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    // Create the list
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] splitWords = text.Split(' ');
        foreach (string w in splitWords)
        {
            _words.Add(new Word(w));    
        }
    }
    // 
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide && !IsCompletelyHidden())
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }
    public string GetDisplayText()
    {
        string text = "";
        foreach (Word w in _words)
        {
            text+= w.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} - {text}";
    }



}