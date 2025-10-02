// Adding the option 6: Delete a given text file from the folder.
using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        string[] Questions = { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What was the most challenging thing I faced today?", "What did I learn today?", "What was the most surprising thing that happened today?", "What did I do today that I am proud of?" };
        bool Game = true;
        string Response="";
        string Title1="";
        string Title2 = "";
        List<string> Rp= new List<string>();
        Console.WriteLine("Welcome to the Journal Program!");
        while (Game)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Delete");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice (1-6): ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Random rm = new Random();
                string RandomChoice = Questions[rm.Next(Questions.Length)];
                Console.WriteLine(RandomChoice);
                Console.Write("> ");
                Response = Console.ReadLine();
                OurTime t = new OurTime();
                string r = t.Out(Response);
                Rp.Add(r);
            }
            if (choice == "3")
            {
                Console.WriteLine("Please enter the title of the Journal you want to load");
                Title1 = Console.ReadLine();
                Checker p = new Checker();
                p.FileName = Title1;
                p.LookFile(Title1);
                if (p.yo == true)
                {
                    Console.WriteLine("File loaded successfully.");
                }
                else
                {
                    Console.WriteLine("That file does not exist, please enter a proper name");
                }
            }
            if (choice == "2")
            {
                if (Rp.Count == 0)
                {
                    if (Title1 == "")
                    {
                         Console.WriteLine();
                         Console.WriteLine("There is nothing to display");
                         Console.WriteLine();
                    }
                }

                if (Title1!="")
                {
                    string content = File.ReadAllText(Title1);
                    Console.WriteLine();
                    Console.WriteLine(content);
                }
                else
                {
                    foreach (string item in Rp)
                    {
                        Console.WriteLine();
                        Console.WriteLine(item);
                    }
                }
            }
            if (choice == "4")
            {
                if (Response == "> " || Response == "")
                {
                    Console.WriteLine("Sorry! There no journal yet, write one before");
                }
                else
                {
                    Console.WriteLine("Please enter a title for your Journal");
                    string Title = Console.ReadLine();
                    using (StreamWriter writer=new StreamWriter(Title))
                    foreach (string item in Rp)
                    {
                        writer.WriteLine(item);
                    }
                    Console.WriteLine("File save successfuly");
                }               
            }
            if (choice == "5")
            {
                Console.WriteLine("Please enter the title of the Journal you want to delete");
                Title2 = Console.ReadLine();
                Checker m = new Checker();
                m.FileName = Title2;
                m.LookFile(Title2);
                if (m.yo == true)
                {
                    Console.WriteLine("File deleted successfully.");
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            if (choice == "6")
            {
                Game = false;
            }
        }
        
    }
}





