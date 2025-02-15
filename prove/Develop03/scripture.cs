public class Scripture
{
    Reference reference;
    List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();
        foreach (string word in text.Split(' '))
            words.Add(new Word(word));
    }

    public void DisplayScripture()
    {
        Console.WriteLine(reference.ToString());
        foreach (Word word in words)
            Console.Write(word.IsHidden ? "____ " : word.Content + " ");
        Console.WriteLine();
    }

    public void RemoveWords()
    {
        Random rand = new Random();
        int wordsToRemove = 2;
        int hiddenCount = words.Count(w => w.IsHidden);

        if (hiddenCount + wordsToRemove >= words.Count)
            wordsToRemove = words.Count - hiddenCount;

        for (int i = 0; i < wordsToRemove; i++)
        {
            List<Word> visibleWords = words.Where(w => !w.IsHidden).ToList();
            if (visibleWords.Count == 0) break;

            int index = rand.Next(visibleWords.Count);
            visibleWords[index].IsHidden = true;
        }
    }

    public bool IsCompletelyHidden()
    {
        return words.All(w => w.IsHidden);
    }
}