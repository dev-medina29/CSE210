using System;

class Program
{
    static void Main(string[] args)
    {
        Random md = new Random();
        int guess = md.Next(1, 101);
        bool game = true;
        while (game)
        {
            Console.Write("What is your guess? ");
            int number = int.Parse(Console.ReadLine());
            if (number == guess)
            {
                Console.WriteLine("You guess it!");
                game = false;
            }
            else if (number < guess)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }
        
    }
}