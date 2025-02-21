public class MathAssignment : Assignment
{
    private string _textbooksection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems): base(studentName, topic)
    {
        _textbooksection = textbookSection;
        _problems = problems;
    }


    public string GetHomeworkList()
    {
        return $"Section: {_textbooksection} - Problem {_problems}";
    }
}