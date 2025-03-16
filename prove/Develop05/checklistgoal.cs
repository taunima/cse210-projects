public class Checklist : Goal
{
    private int _completed;
    private int _totalToComplete;
    private int _bonusPoints; 
    
    public Checklist(string name, string description, int points, int totalToComplete, int bonusPoints): base(name, description, points)
    {
        _completed = 0;
        _totalToComplete = totalToComplete;
        _bonusPoints = bonusPoints;
    }

    public override bool IsCompleted() => _completed >= _totalToComplete;

    public override void Display()
    {
        Console.WriteLine($"[ {(IsCompleted() ? "X" : " ")} ] {GetName()} - {GetDescription()} ({GetPoints()} pts per record, Bonus: {_bonusPoints} pts at {_totalToComplete}) - Completed {_completed}/{_totalToComplete}");
    }

    public override int RecordEvent()
    {
        if (_completed < _totalToComplete)
        {
            _completed++;
            return GetPoints() + (IsCompleted() ? _bonusPoints : 0);
        }
        return 0;
    }

    public override string GetRepresentation()
    {
        return $"Checklist,{GetName()},{GetDescription()},{GetPoints()},{_completed},{_totalToComplete},{_bonusPoints}";
    }
}