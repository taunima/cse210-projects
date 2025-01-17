using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        {
        DisplayMessage();

        string nameMessage = DisplayNameMessage();

        int number = FavoriteNumber();

        int squarenumber = SquareNumber(number);

        DisplayResult(nameMessage, squarenumber);

        }

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string DisplayNameMessage()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int FavoriteNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}