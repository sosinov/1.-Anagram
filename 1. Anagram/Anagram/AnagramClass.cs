public class AnagramClass
{
    public const string defaultErrorMessage = "Invalid data introduced...";

    private string _phrase;
    public string phrase 
    {
        get { return _phrase; }
        private set
        {
            if (value == null)
            {
                throw new ArgumentException(
                   "Parameter phrase may not be null.");
            }
            _phrase = value;
        }
    }

    public AnagramClass(string inputSentence)
    {
        phrase = inputSentence;
    }

    public string Reverse()
    {
        string[] words = _phrase.Split(' ');
        var reversedPhrase = words.Select(word => ReverseWord(word));
        return string.Join(' ', reversedPhrase);
    }

    private string ReverseWord(string word)
    {
        Stack<string> letterStrings = new Stack<string>();
        List<string> simbolsStrings = new List<string>();
        string resultWord = "";

        // Search/save initial simbols positions
        for (int i = 0; i < word.Length; i++)
        {
            if (Char.IsLetter(word[i]))
            {
                letterStrings.Push(word[i].ToString());
            }
            else
            {
                simbolsStrings.Add(word[i].ToString());
            }
        }

        // Reverse input word, using criteria
        for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsLetter(word[i]))
                {
                    resultWord += letterStrings.Pop();
                }
                else
                {
                    resultWord += simbolsStrings.First();
                    simbolsStrings.Remove(simbolsStrings.First());
                }
            }        
        return resultWord;
    }
}