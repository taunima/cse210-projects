using System;

class Program
{
    static void Main(string[] args)
    {
        Event lecture = new Lecture("AI for Everyone", "An introductory lecture on AI.", "April 10", "6:00 PM", "381 Motherboard Ln", "Dr. Robin Jane", 100);
        Event reception = new Reception("Shawn and Jackie's Wedding", "Come celebrate with the McDougal's!", "April 12", "7:00 PM", "974 Fishy Way", true);
        Event outdoor = new Outdoor("Latern Festival", "Come see and light your own latern!", "August 15", "3:00 PM", "573 King's Dr", "Clear skies and 75°F");

        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (Event e in events)
        {
            Console.WriteLine("--- Standard Details ---");
            Console.WriteLine(e.DisplayStandardSummary());
            Console.WriteLine("--- Full Details ---");
            Console.WriteLine(e.DisplayFullSummary());
            Console.WriteLine("--- Short Description ---");
            Console.WriteLine(e.DisplayShortSummary());
        }
    }        
}