using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "MTN";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._company = "Apple";
        job2._startYear = 2018;
        job2._endYear = 2020;

        Resume myresume = new Resume();
        myresume._name = "Medina MBEDI";
        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);

        myresume.Display();
        

    }
}