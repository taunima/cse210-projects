using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Assignment student = new Assignment("Samuel Bennett", "Multiplication");
        string summary = student.GetSummary();
        Console.WriteLine(summary);

        MathAssignment massigment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        string math = massigment.GetHomeworkList();
        Console.WriteLine(math);

        WritingAssignment wassignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string writing = wassignment.GetSummary();
        Console.WriteLine(writing);

    }
}