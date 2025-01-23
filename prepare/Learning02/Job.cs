public class Job
{
    public string _jobTitle ;

    public string _company ;

    public int _startdate ;

    public int _enddate ;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle}, ({_company}), {_startdate}-{_enddate}");
    }
}