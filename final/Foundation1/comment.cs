using System.Net.Mime;

public class Comment
{
    public string _name;

    public string _content;

    public Comment(string name, string content)
    {
        _name = name;
        _content = content;
    }
    public void Display()
    {
        Console.WriteLine($"- {_name}: {_content}");
    }
}