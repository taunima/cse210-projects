using System.Runtime.CompilerServices;

public class Video
{
    public string _title;

    public string _author;

    public string _length;

    public List<Comment> _comment;

    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comment = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comment.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comment.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");

        foreach (var comment in _comment)
        {
            comment.Display();
        }

        Console.WriteLine(new string('-', 40));
    }
}