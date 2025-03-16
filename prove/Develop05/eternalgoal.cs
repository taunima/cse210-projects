using System.ComponentModel;

public class Eternal : Goal
{
    public Eternal(string name, string description, int points): base(name, description, points)
    {
        ;
    }

    public override void Display()
    {
        Console.WriteLine($"[ ∞ ] {GetName()} - {GetDescription()} ({GetPoints()} pts per record)");
    }

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override string GetRepresentation()
    {
        return $"Eternal,{GetName()},{GetDescription()},{GetPoints()}";
    }
}