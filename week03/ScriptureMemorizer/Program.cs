// Ask the user to enter a proper key 

using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool game = true;
        List<int> indx = new List<int>();
        fileCoverter p = new fileCoverter();
        p.SetfilePath(@"C:\Users\MEDI\OneDrive\PC First and basic notes\CSE210\week03\ScriptureMemorizer\scripture.txt");
        string[] yes = p.fConverter();
        Scripture yeap = new Scripture();
        yeap.SetList(p.words);
        yeap.Display();
         // Console.WriteLine("Yes it works");
        string real = yeap.manager3();
        string real2 = yeap.manager2();
        List<string> ya = real.Split(" ").ToList();
        WordChange medina = new WordChange();
        medina.Setter(ya);
        while (game == true)
        {
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string Decision = Console.ReadLine();
            if (Decision == "")
            {
                game=medina.Ind(game);
                Console.Clear();
                Console.Write(real2);
                medina.SetWord(indx);
                
                
            }
            else
            {
                if (Decision != "quit" & Decision != "")
                {
                    Console.Clear();
                    Console.WriteLine("Enter a valid key please");
                }
                else
                {
                    game = false;
                    Console.Clear();
                    Console.WriteLine("Bye");
                }

            }
        }
       
    }
}
