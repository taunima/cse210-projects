public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, string address, string weather): base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string DisplayFullSummary()
    {
        return $"{DisplayFullSummary()} Weather forecast: {_weather}";
    }
}