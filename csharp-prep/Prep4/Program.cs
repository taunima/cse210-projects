using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a nmber, type 0 when finished.");
        List<int> numbers = new List<int>();
        
        int numberuser = -1;
        while (numberuser != 0)
        {
            Console.Write("Enter a nmber: ");
            string response = Console.ReadLine();
            numberuser = int.Parse(response);

            if (numberuser != 0)
            {
                numbers.Add(numberuser);
            }
        }
        int sum = 0;

        foreach (int number in numbers) 
        {
            sum += number;
        }

        Console.WriteLine($"The sum is {sum}.");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is {max}.");
    }
}