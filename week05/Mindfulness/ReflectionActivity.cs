using System;

public class ReflectionActivity : Activity
{
    private List<String> _promps = new List<string>
    {
        "Think of a time when you stood up for someone else."
        "Think of a time when you did something really difficult."
        "Think of a time when you helped someone in need."
        "Think of a time when you did something truly selfless."
    }
    public ReflectionActivity() : base("Reflection","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life")
    {
    }
    public void Run()
    {
        StartActivity();

        Random random New Random();
        int index = random.Next(_promps.Count);
        Console.WriteLine($"\n--- {_promps[index]} ---");

        ShowSpinner(5);

        DisplayEndingMessage();
    }

}