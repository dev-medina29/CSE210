using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string letter;
        string a = Console.ReadLine();
        int grade = int.Parse(a);
        if (grade >= 70)
        {
            if (grade >= 90)
            {
                letter = "A";
            }
            else if (grade >= 80)
            {
                letter = "B";
            }
            else
            {
                letter = "C";
            }
            Console.Write($"Congratulations, you passed the class and your grade is {letter}.");
        }
        else
        {
            if (grade >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }
            Console.Write($"Unfortunately, you did not pass the class and your grade is {letter}.");
        }
    }
}