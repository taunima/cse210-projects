using System;
using System.Collections.Generic;

public class Journal

{
    public List<Entry> _entries {get; } = new List<Entry>();
    public List<string> _promptList = new List<string>
    {
        "What was the peak of today?",
        "What was a pit of today?",
        "What made you smile today?",
        "Did you help someone today?",
        "How did you attack the day?",
        "What are you grateful for?"
    };
    
public void AddEntry()
    {
        Entry newEntry = new Entry();

        newEntry._date = DateTime.Now.ToString("yyyy-MM-dd");
        newEntry._prompt = GeneratePrompt();
        
        Console.WriteLine($"\n{newEntry._prompt}");
        Console.Write("Your Response: ");
        newEntry._response = Console.ReadLine();

        Console.Write("Rate your day (1-5): ");
        while (!int.TryParse(Console.ReadLine(), out newEntry._dayrating) || newEntry._dayrating < 1 || newEntry._dayrating > 5)
        {
            Console.Write("Invalid input. Enter a number between 1 and 5: ");
        }

        _entries.Add(newEntry);
        Console.WriteLine("Entry added successfully!");
    }

    public void DisplayJournal()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("\nNo journal entries yet.");
            return;
        }

        Console.WriteLine("\n--- Journal Entries ---");
        foreach (Entry entry in _entries)
        {
            entry.NewEntry();
        }
    }

    public string GeneratePrompt()
    {
        Random rand = new Random();
        return _promptList[rand.Next(_promptList.Count)];
    }
}
