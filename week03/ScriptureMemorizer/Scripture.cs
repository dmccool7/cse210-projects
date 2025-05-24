public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] split = text.Split(" ");

        foreach (string newWord in split)
        {
            string cleanWord = newWord;
            if (cleanWord.Length > 0)
            {
                char last = cleanWord[cleanWord.Length - 1];

                if (last == ',' || last == '.'|| last == ';')
                {
                    string clean = "";
                    for (int i = 0; i < cleanWord.Length - 1; i++)
                    {
                        clean += cleanWord[i];
                    }

                    _words.Add(new Word(clean));

                    Word punctuationWord = new Word(last.ToString());
                    punctuationWord.Show();
                    _words.Add(punctuationWord);
                }

                else
                {
                    _words.Add(new Word(cleanWord));
                }
            }
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visible = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visible.Add(word);
            }
        }

        int count = numberToHide;
        if (visible.Count < numberToHide)
        {
            count = visible.Count;
        }

        for (int i = 0; i < count; i++)
        {
            int index = random.Next(visible.Count);
            visible[index].Hide();
            visible.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string text = "";

        for (int i = 0; i < _words.Count; i++)
        {
            text += _words[i].GetDisplayText();

            if (i < _words.Count - 1)
            {
                text += " ";
            }
        }

        return $"{referenceText} {text}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}