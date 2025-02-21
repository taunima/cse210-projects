public class Assignment
{
    private string _name;
    private string _topic;

    public Assignment(string studentName, string studentTopic)
    {
        _name = studentName;
        _topic = studentTopic;
    }

    public string GetSummary()
    {
        string assignment = $"{_name} - {_topic}";
        return assignment;
    }
}