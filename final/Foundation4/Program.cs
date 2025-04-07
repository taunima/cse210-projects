using System;
using System.ComponentModel;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        
        activities.Add(new Running("9 Jul 2025", 30, 3));
        activities.Add(new Biking("24 Sept 2025", 45, 5));
        activities.Add(new Swimming("30 Nov 2025", 60, 12));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
