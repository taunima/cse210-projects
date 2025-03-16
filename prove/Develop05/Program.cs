using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {}
    private static List<Goal> _goals = new List<Goal>();
    private static int _userScore = 0;
    private static string _saveFile = "goals.txt";

    static void Main()
    {
        LoadGoals();

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goals");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record an Event");
            Console.WriteLine("6. Quit");

            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            if (choice == "1") CreateGoal();
            else if (choice == "2") DisplayGoals();
            else if (choice == "3") SaveGoals();
            else if (choice == "4") LoadGoals();
            else if (choice == "5") RecordEvent();
            else if (choice == "6") break;
            else Console.WriteLine("Invalid choice. Try again.");
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal (One-time completion)");
        Console.WriteLine("2. Eternal Goal (Repeatable)");
        Console.WriteLine("3. Checklist Goal (Multiple completions + Bonus)");

        Console.Write("Enter choice: ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter point value: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new Simple(name, description, points));
        }
        else if (type == "2")
        {
            _goals.Add(new Eternal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("Enter number of times to complete: ");
            int totalToComplete = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points upon completion: ");
            int bonusPoints = int.Parse(Console.ReadLine());
            _goals.Add(new Checklist(name, description, points, totalToComplete, bonusPoints));
        }

        Console.WriteLine("Goal added!\n");
    }

    static void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        foreach (var goal in _goals)
        {
            goal.Display();
        }
        Console.WriteLine($"Total Score: {_userScore} pts\n");
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter(_saveFile))
        {
            writer.WriteLine(_userScore);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetRepresentation());
            }
        }
        Console.WriteLine("Goals saved!\n");
    }

    static void LoadGoals()
    {
        if (File.Exists(_saveFile))
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines(_saveFile);
            _userScore = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (type == "Simple")
                {
                    bool completed = bool.Parse(parts[4]);
                    var goal = new Simple(name, description, points);
                    if (completed) goal.RecordEvent();
                    _goals.Add(goal);
                }
                else if (type == "Eternal")
                {
                    _goals.Add(new Eternal(name, description, points));
                }
                else if (type == "Checklist")
                {
                    int completed = int.Parse(parts[4]);
                    int totalToComplete = int.Parse(parts[5]);
                    int bonusPoints = int.Parse(parts[6]);
                    var goal = new Checklist(name, description, points, totalToComplete, bonusPoints);
                    for (int j = 0; j < completed; j++) goal.RecordEvent();
                    _goals.Add(goal);
                }
            }
            Console.WriteLine("Goals loaded!\n");
        }
        else
        {
            Console.WriteLine("No save file found.\n");
        }
    }

    static void RecordEvent()
    {
        Console.WriteLine("\nSelect a goal to record:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].Display();
        }

        Console.Write("\nEnter goal number: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= _goals.Count)
        {
            int pointsEarned = _goals[choice - 1].RecordEvent();
            _userScore += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points! Total Score: {_userScore} pts\n");
        }
        else
        {
            Console.WriteLine("Invalid selection.\n");
        }
    }
}