using System;
using System.IO;
using System.Collections.Generic;
public class WordChange
{
    private bool indicator=true;
    private List<int> indx = new List<int>();
    private List<string> Listofword;
    public void Setter(List<string> belou)
    {
        Listofword = belou;
    }
    public bool Ind(bool kl)
    {
        kl = indicator;
        return indicator;
    }
    public void SetWord(List<int> index)
    {
        Random rdm = new Random();
        for (int i = 0; i < 3; i++)
        {
            int NumberToHide = rdm.Next(Listofword.Count);
            bool ck = index.Contains(NumberToHide);
            while (ck == true)
            {
                NumberToHide = rdm.Next(Listofword.Count);
                ck = index.Contains(NumberToHide);
                if (index.Count == Listofword.Count)
                {
                    break;
                }
            }
            if (ck == false)
            {
                index.Add(NumberToHide);
                Listofword[NumberToHide] = new string('_', Listofword[NumberToHide].Length);

            }

        }
        foreach (string item in Listofword)
        {

            Console.Write($" {item} ");
        }
        if (index.Count == Listofword.Count)
        {
            indicator = false;
        }
    }

}