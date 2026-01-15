using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle ="Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle ="Mechanical";
        job2._company ="Apple";
        job2._startYear = 2020;
        job2._endYear= 2025;

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._personName ="Alexis Sanchez";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        Console.WriteLine("Primer trabajo: "+ myResume._jobs[0]._jobTitle);

        myResume.Display();

    }
}

