using System.Diagnostics;

public class Reflection : Activity
{
    private List<string> _prompts = new List<string> {};
    private List<string> _reflectionQuestions = new List<string> {};

    public Reflection(string activity, int duration): base(activity, duration)
    {
        _prompts = new List<string> {"What is you greatest weakness?", "What is your greatest strength?", "What is somehthing you can improve on now?", "How are you becoming better?", "What are you doing now to change?"};

        _reflectionQuestions = new List<string> {"How did today this help you?", "What did you learn from this?", "Did today bring you happiness?", "What brings you joy?", "What did you accomplish today?"};
    }

    public Reflection(List<string> prompts, List<string> reflectionQuestions, string activity, int duration): base(activity, duration)
    {
        _prompts = prompts;
        _reflectionQuestions = reflectionQuestions;
    }

    public void DisplayReflectionQuestion(List<string> reflectionQuestions, int index)
    {
        Console.WriteLine(reflectionQuestions[index]);
    }

    public void DisplayReflectionProcess(Stopwatch time, int duration)
    {
        bool timeLeft = true;

        for (int i = 0; i < _reflectionQuestions.Count; i++)
        {
            DisplayReflectionQuestion(_reflectionQuestions, i);
            Loading(10);

            timeLeft = IsThereTime(time, duration);
            if (timeLeft == false)
            {
                break;
            }
        }
    }

    public void DoActivity()
    {
        Console.WriteLine("Welcome to the Reflection Activity.");
        Console.WriteLine("This activity is to help you reflect on what you can do better and to improve yourself in small ways that can be helpful in the long run.");

        int duration = GetDuration();
        GetReady();

        var timeTrack = new Stopwatch();
        timeTrack.Start();

        while (timeTrack.Elapsed < TimeSpan.FromSeconds(duration))
        {
            Console.WriteLine("Consider the following prompt: ");

            string randomPrompt = GetRandomPrompt(_prompts);
            DisplayPrompt(randomPrompt);

            Console.WriteLine("When you have finished answering the prompt, press enter to continue.");

            Console.ReadLine();

            Console.WriteLine("Now just think about the following questions and how they related to this experience.");
            ShowCountdown(4);
            Console.WriteLine();

            DisplayReflectionProcess(timeTrack, duration);

            DisplayDone();
        }
    }
}