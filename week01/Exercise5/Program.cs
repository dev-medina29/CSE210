using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        DisplayWelcome();
        static string PromptUserName()
        {
            Console.Write("Enter your name please: ");
            string yo = Console.ReadLine();
            return yo;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string number = Console.ReadLine();
            int FavoriteNumber = int.Parse(number);
            return FavoriteNumber;
        }
        static int SquareNumber(int number)
        {
            int result = number * number;
            return result;
        }
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"Your Name is {name} and the square of your number is {square}. ");
        }

        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);

        DisplayResult(name, square);
    }
}
