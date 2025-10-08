using System;
using System.Threading;
public class ListingActivity : Activity
{
    private List<string> Prompt = new List<string> { "Who are people that you appreciate?","What are personal strengths of yours?", "Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage("Breathing Activity");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> responses = new List<string>();
        while (DateTime.Now < endTime)
        {
            Random random = new Random();
            int index = random.Next(Prompt.Count - 1);
            Console.WriteLine("List as many responses you can to the following prompt:");
            Console.WriteLine($"--- {Prompt[index]} ---");
            Console.Write("You may begin in: ");
            ShowCountdown(5);
            Console.WriteLine();
            int itemCount = 0;
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string response = Console.ReadLine();
                responses.Add(response);
                itemCount++;
            }
            Console.WriteLine($"You listed {itemCount} items!");
            DisplayEndingMessage();
        }
    }
}