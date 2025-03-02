using System.Diagnostics;

public class Breathing : Activity
{
    public Breathing(string activity, int duration): base(activity, duration)
    {

    }

    public void DoActivity()
    {
        Console.WriteLine("Welcome to the Breathing Activity");
        Console.WriteLine("This activity will help you to relax and refocus.");

        int duration = GetDuration();
        Console.Clear();

        GetReady();

        var timeTrack = new Stopwatch();

        while(timeTrack.Elapsed < TimeSpan.FromSeconds(duration))
        {
            Console.Write("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountdown(6);
            Console.WriteLine();
        }
        Console.WriteLine("");
        DisplayDone();
    }
}