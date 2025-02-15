using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureList scriptureList = new ScriptureList();
        Scripture scripture = scriptureList.RandomScriptureChosen();

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            scripture.DisplayScripture();
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");

            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
                break;

            scripture.RemoveWords();
        }

        Console.WriteLine("Congratulations! You've memorized the scripture.");
    }
}