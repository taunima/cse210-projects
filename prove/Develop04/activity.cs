using System.Diagnostics;

public class Activity
{
    private string _activity;

    private int _duration;

    public Activity()
    {
        _duration = 0;
    }

    public Activity(string activity, int duration)
    {
        _activity = activity;
        _duration = duration;
    }

    public int GetDuration()
    {
        Console.Write("How long would you like this activity to go?");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
        return _duration;
    }

    public void Loading(int time)
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();

        while(timer.Elapsed < TimeSpan.FromSeconds(time))
        {
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("|");
        }
        timer.Stop();
        Console.WriteLine();
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Loading(4);
    }

    public void ShowCountdown(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public string GetRandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        int randomInRange = random.Next(0, prompts.Count);
        return prompts[randomInRange];
    }

    public void DisplayPrompt(string randomPrompt)
    {
        Console.WriteLine($"-- {randomPrompt} --");
    }

    public bool IsThereTime(Stopwatch time, int duration)
    {
        if (time.Elapsed < TimeSpan.FromSeconds(duration))
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public void DisplayDone()
    {
        Console.WriteLine("Done.");
        Console.WriteLine($"You have completed another {_duration} seconds of {_activity} Activity.");
        Loading(4);
    }
}