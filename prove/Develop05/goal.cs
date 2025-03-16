using System.Collections.Concurrent;
using System.ComponentModel;

public class Goal
{
    private string _name;

    private string _description;
    
    private int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName() => _name;
    public string GetDescription() => _description;
    public int GetPoints() => _points;

    public virtual bool IsCompleted()
    {
        return false;
    }

    public virtual void Display()
    {
        Console.WriteLine($"{_name} - {_description} ({_points} pts)");
    }

    public virtual int RecordEvent()
    {
        return 0;
    }

    public virtual string GetRepresentation()
    {
        return $"Goal,{_name},{_description},{_points}";
    }
}