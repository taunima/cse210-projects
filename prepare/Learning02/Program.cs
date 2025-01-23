using System;

class Program
{
    static void Main(string[] args)
    { 
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startdate = 2019;
        job1._enddate = 2024;
        job1.DisplayJobDetails();

        ///Console.WriteLine($"{job1._jobTitle}, ({job1._company}), {job1._startdate} - {job1._enddate}");

        Job job2 = new Job();
        job2._jobTitle = "Finance Analyst";
        job2._company = "Apple";
        job2._startdate = 2020;
        job2._enddate = 2026;
        job2.DisplayJobDetails();

        Resume myresume = new Resume();
        myresume._name = "Simon Taunima";
        myresume._job.Add(job1);
        myresume._job.Add(job2);
        myresume.Display();

        ///Console.WriteLine($"{job2._jobTitle}, ({job2._company}), {job2._startdate} - {job2._enddate}");
    }
}