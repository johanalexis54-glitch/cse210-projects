using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    public void Run()
    {
        StartActivity();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\n\n Breath in...");
            ShowCountDown(4);

            Console.WriteLine("\n\n Breath out...");
            ShowCountDown(6);
        }

        DisplayEndingMessage();
    }

    private void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}