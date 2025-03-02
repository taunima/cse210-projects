using System.Diagnostics;

public class Listing : Activity
{
    List<string> _prompts = new List<string>();

    public Listing(string activity, int duration): base(activity, duration)
    {
        _prompts = new List<string> {"What is something that you are grateful for?", "What was something that was good this week?", "What could you do better for the coming week?", "What do you need for the day?", "How can you do better today?"};
    }

    public void DoActivity()
    {
        Console.WriteLine("Welcome to the Listing Activity");
        Console.WriteLine("This activity will help you to reflect on what you are doing for the week and your day as well.");

        int duration = GetDuration();
        GetReady();

        var timeTrack = new Stopwatch();
        timeTrack.Start();

        string prompt = GetRandomPrompt(_prompts);
        DisplayPrompt(prompt);

        Console.Write("You may begin in ");
        ShowCountdown(5);
        Console.WriteLine("");

        int entryCount = 0;

        while (timeTrack.Elapsed < TimeSpan.FromSeconds(duration))
        {
            Console.Write(">");
            Console.ReadLine();
            Console.WriteLine();

            entryCount++;
            bool done = IsThereTime(timeTrack, duration);
            if (done == false)
            {
                break;
            }
        }

        Console.WriteLine($"You listed {entryCount} items.");
        DisplayDone();
    }
}