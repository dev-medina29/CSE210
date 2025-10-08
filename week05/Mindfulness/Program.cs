// Make sure no random questions or prompts are displayed twice as long as others are not displayed. (I put the code in the ReflectionActivity class)
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        bool continueProgram = true;
        while (continueProgram)
        {
            Console.WriteLine("Welcome to the Mindfulness App!");
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity activity1 = new BreathingActivity();
                activity1.Run();
            }
            if (choice == "3")
            {
                ListingActivity activity3 = new ListingActivity();
                activity3.Run();
            }
            if (choice == "2")
            {
                ReflectionActivity activity2 = new ReflectionActivity();
                activity2.Run();
            }
            if (choice == "4")
            {
                continueProgram = false;
            }
        }
    }
    
}