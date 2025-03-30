using System;
using System.Collections.Generic;
using System.IO;

class Files
{
private const string Separator = " ~|~ ";

    public void SaveJournal(Journal journal)
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in journal._entries)
            {
                writer.WriteLine($"{entry._date}, {entry._prompt}, {entry._response}");
            }
        }

        Console.WriteLine("Journal saved successfully!");
    }

    public Journal LoadJournal()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. Creating a new journal.");
            return new Journal();
        }

        Journal journal = new Journal();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(new string[] { Separator }, StringSplitOptions.None);
                if (parts.Length == 4)
                {
                    Entry entry = new Entry();
                    entry._date = parts[0];
                    entry._prompt = parts[1];
                    entry._response = parts[2];
                    entry._dayrating = int.Parse(parts[3]);

                    journal._entries.Add(entry);
                }
            }
        }

        Console.WriteLine("Journal loaded successfully!");
        return journal;
    }
}
