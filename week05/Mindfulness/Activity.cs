using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    //The first Standart Message
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity. \n");
        Console.WriteLine($"{_description} \n");
        Console.WriteLine($"How Long, in seconds, do you like for your session?");

        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\n Get Ready...");
        ShowSpinner(3);
    }
    //Second Standart Message
    private string GetCongratulations() => $"Congratulations - Great Job";
    public void  DisplayEndingMessage()
    {
        Console.WriteLine("\n" + GetCongratulations());
        Console.WriteLine($"You have complet another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
    }
    // Spinner Method
    public void ShowSpinner(int seconds)
    {
        for(int x =0; x < seconds * 2; x++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("_");
            Thread.Sleep(250);
            Console.Write("\b \b");
            
        }
        Console.WriteLine();
    }

}
