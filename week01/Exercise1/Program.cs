using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your last name?");
        string name = Console.ReadLine();

        Console.Write("What is your first name?");
        string firstName = Console.ReadLine();

        Console.Write($"Hello  Your name is {name},{firstName} {name}.");
    }
}