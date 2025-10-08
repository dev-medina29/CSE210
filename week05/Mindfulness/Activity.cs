using System;
public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    
    public void DisplayStartingMessage(string name)
    {
        Console.WriteLine($"Welcome to the {name} activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.Clear();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity.");
        ShowSpinner(3);
        Console.Clear();
    }
    public void ShowSpinner(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }

    }
    public void ShowCountdown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();

    }
   
}