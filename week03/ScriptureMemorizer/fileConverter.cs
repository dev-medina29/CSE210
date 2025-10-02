using System;
using System.IO;
using System.Collections.Generic;
public class fileCoverter
{
    private string text;
    public string[] words;
    private string filepath;
    
    Random choice = new Random();

    public void SetfilePath(string filePath1)
    {
        filepath=filePath1;
    }
    public string[] fConverter()
    {
        List<string> List1 = File.ReadAllLines(filepath).ToList();
        int lg = List1.Count;
        text = List1[choice.Next(lg)];
        words = text.Split('.');
        return words;
    }

}