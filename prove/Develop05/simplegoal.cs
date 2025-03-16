public class Simple : Goal
{
    private bool _completed;

    public Simple(string name, string description, int points): base(name, description, points)
    {
        _completed = false;
    }

    public override bool IsCompleted() => _completed;

    public override void Display()
    {
        Console.WriteLine($"[ {(IsCompleted() ? "X" : " ")} ] {GetName()} - {GetDescription()} ({GetPoints()} pts)");
    }

    public override int RecordEvent()
    {
        if (!_completed)
        {
            _completed = true;
            return GetPoints();
        }
        return 0;
    }

    public override string GetRepresentation()
    {
        return $"Simple,{GetName()},{GetDescription()},{GetPoints()},{_completed}";
    }
}