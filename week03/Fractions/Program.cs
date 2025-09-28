using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction fract2 = new Fraction(5);
        Console.WriteLine(fract2.GetFractionString());
        Console.WriteLine(fract2.GetDecimalValue());

        Fraction fract3 = new Fraction(1, 3);
        Console.WriteLine(fract3.GetFractionString());
        Console.WriteLine(fract3.GetDecimalValue());

        Fraction fract4 = new Fraction(1, 3);
        Console.WriteLine(fract4.GetFractionString());
        Console.WriteLine(fract4.GetDecimalValue());
    }
}