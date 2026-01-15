using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Savejournal to file");
            Console.WriteLine("4. Load journal to file");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Chosse an option: ");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.WriteLine("Your response: ");
                    string text = Console.ReadLine();
                    Entry entry = new Entry(DateTime.Now, prompt, text);
                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.WriteLine("Filename: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case "4":
                    Console.WriteLine("Filename: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        
        }

    }
}