using System;

class Program
{
    static void Main(string[] args)
    {
        bool done = false;

        while(!done)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();

            int option = int.Parse(input);

            if (option == 1)
            {
                var breathing = new Breathing("Breathing", 0);
                breathing.DoActivity();
            }

            else if (option == 2)
            {
                var reflection = new Reflection("Reflection", 0);
                reflection.DoActivity();
            }

            else if (option == 3)
            {
                var listing = new Listing("Listing", 0);
                listing.DoActivity();
            }

            else if (option == 4)
            {
                done = true;
            }
        }
    }
}