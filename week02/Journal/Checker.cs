using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
public class Checker
{
    public string FileName;
    public bool yo;
    public bool LookFile(string input)
    {
        input = FileName;
        if (File.Exists(input))
        {
            yo = true;
            return yo;
        }
        else
        {
            yo = false;
            return yo;
        }
    }
}
