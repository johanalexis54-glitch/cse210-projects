using System;
using System.Collections.Generic;
public class ListActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {}
    public void Run()
    {
        StartActivity();

        Random random = new Random();
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[random.Next(_prompts.Count)]} ---");

        Console.Write("You may Begin in: ");
        ShowSpinner(5);

        List<string> userList = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            
            if (!string.IsNullOrEmpty(input))
            {
                userList.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {userList.Count} items!");

        DisplayEndingMessage();
    }
}