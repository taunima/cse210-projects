using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
       Journal journal = new Journal();
        Files file = new Files();

        while (true)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a New Entry");
            Console.WriteLine("2. Display the Journal");
            Console.WriteLine("3. Save Journal to File");
            Console.WriteLine("4. Load Journal from File");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1") journal.AddEntry();
            else if (choice == "2") journal.DisplayJournal();
            else if (choice == "3") file.SaveJournal(journal);
            else if (choice == "4") journal = file.LoadJournal();
            else if (choice == "5") break;
            else Console.WriteLine("Invalid choice, please try again.");
        }
    }
}


/// for classes don't use static