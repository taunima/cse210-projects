using System.Reflection;

public class Event
{
    private string _title;

    private string _description;

    private string _date;

    private string _time;

    private string _address;

    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string DisplayStandardSummary()
    {
        return $"{_title} - {_description} When:{_date} - {_time} Where: {_address}";
    }

    public virtual string DisplayFullSummary()
    {
        return DisplayStandardSummary();
    }

    public virtual string DisplayShortSummary()
    {
        return $"Event: {_title} When: {_date}";
    }
}