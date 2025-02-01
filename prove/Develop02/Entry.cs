using System.ComponentModel.DataAnnotations;

public class Entry
{
    public string _prompt;
    public string _response;
    public string _date;
    public int _dayrating;


    public void NewEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}, {_response}, {_dayrating}");
    }
}