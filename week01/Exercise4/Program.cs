using System;
using System.Globalization;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a list of numebers, type 0 when finished:");
        List<float> table = new List<float>();
        while (true)
        {
            Console.Write("Enter Number: ");
            string yo = Console.ReadLine();
            float number = float.Parse(yo);
            if (number == 0)
            {
                break;
            }
            table.Add(number);
        }
        float sum = 0;
        float largest_value = 0;

        for (int i = 0; i < table.Count; i++)
        {
            if (table[i] > largest_value)
            {
                largest_value = table[i];
            }
            sum += table[i];
        }
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {sum / table.Count}");
        Console.WriteLine($"The largest number is {largest_value}"); 
    }
}