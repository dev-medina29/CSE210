using System;
using System.IO;
using System.Collections.Generic;
public class Scripture
{
    private string[] good;

    public void SetList(string[] lst)
    {
        good = lst;

    }
    public void Display()
    {
        foreach (string item in good)
        {
            if (item != "")
            {
                Console.Write($"{item} ");
            }
        }
    }
    public string[] manager1()
    {
        string secondList = good[1];
        string[] newList = secondList.Split("");
        return newList;
    }
    public string manager2()
    {
        string firstList = good[0];
        return firstList;
    }
     public string manager3()
    {
        string firstList2 = good[1];
        return firstList2;
    }
}