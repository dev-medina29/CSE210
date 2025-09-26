using System.Diagnostics.CodeAnalysis;
using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Enumeration;
using System.Xml;
public class OurTime
{
    public int day;
    public int month;
    public int year;
    public string prompt;
    DateTime now = DateTime.Now;
    public string Out(string response)
    {
        DateTime now = DateTime.Now;
        int day = now.Day;
        int month = now.Month;
        int year = now.Year;
        string output = $"{day}/{month}/{year} - Prompt: {response}";
        return output;

    }
}