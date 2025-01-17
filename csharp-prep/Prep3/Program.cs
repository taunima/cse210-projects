using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        int guessednumber = -1;

        while (number != guessednumber)
        {
            Console.WriteLine("What is your guess? ");
            string guess = Console.ReadLine();
            guessednumber = int.Parse(guess);

            if (number > guessednumber)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guessednumber)
            {
                Console.WriteLine("Lower");
            }
        }
    Console.WriteLine("You got it!");
    }
}