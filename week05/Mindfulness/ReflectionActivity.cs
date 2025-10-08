using System;
using System.Threading;
public class ReflectionActivity : Activity
{
    private List<string> Prompt = new List<string> { "Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
    private List<string> Question = new List<string> { "Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage("Reflection Activity");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> items = new List<string>();
        List<string> pItems = new List<string>();
        while (DateTime.Now < endTime)
        {
            Random random = new Random();
            int index = random.Next(Prompt.Count);
            while (pItems.Contains(Prompt[index]))
            {
                index = random.Next(pItems.Count);
                // int i = 0;
                while (items.Contains(pItems[index]))
                {
                    index +=1;
                    if (index >= pItems.Count)
                    {
                        index = 0;
                        pItems.Clear();
                        break;
                    }
                    // i++;
                }
            }
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine($"--- {Prompt[index]} ---");
            pItems.Add(Prompt[index]);
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            ShowCountdown(5);
            Console.Clear();
            while (DateTime.Now < endTime)
            {
                int qIndex = random.Next(Question.Count);
                // int i = 0;
                while (items.Contains(Question[qIndex]))
                {
                    qIndex += 1;
                    if (qIndex >= Question.Count)
                    {
                        qIndex = 0;
                        items.Clear();
                        break;
                    }
                    // i++;
                }
                items.Add(Question[qIndex]);
                Console.Write($"> {Question[qIndex]} ");
                ShowSpinner(10);
                Console.WriteLine();
            }
        }
        DisplayEndingMessage();
    }
}