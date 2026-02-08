using System;

public class ReflectionActivity : Activity
{
    private List<String> _promps = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?"
    };
    public ReflectionActivity() : base("Reflection","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life")
    {}
    public void Run()
    {
        StartActivity();

        Random random = new Random();
        int index = random.Next(_promps.Count);
        Console.WriteLine($"\n--- {_promps[index]} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            int qIndex = random.Next(_questions.Count);
            Console.Write($"\n> {_questions[qIndex]} ");
            ShowSpinner(5);
        }


        DisplayEndingMessage();
    }

}