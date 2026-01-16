using System;

class Entry
{
    public DateTime date {get;}
    public string prompt {get;}
    public string text {get;}

    public Entry(DateTime date, string prompt, string text)
    {
        this.date = date;
        this.prompt = prompt;
        this.text = text;
    }

    public void Display()
    {
        Console.WriteLine($"{date.ToShortDateString()} - prompt: {prompt}");
        Console.WriteLine($"Response: {text}");
        Console.WriteLine("----------------------------------------------------");
    }
}