using System;
// I need using a database for complet the project.
public class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("Wellcome!! Here you will should memorize your favorit scrpture");

        bool running = true;
        while (running)
        {
            Console.WriteLine("which of the following scripture do you want to memorize?");
            Console.WriteLine("1. Juan 3:16");
            Console.WriteLine("2. Salmos 23:;1");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();
            
            Scripture selectedScripture = null;

            switch (choice)
            {
                case "1":
                    Reference ref1 = new Reference("Juan", 3, 16);
                    selectedScripture = new Scripture(ref1, "Porque de tal manera amó Dios al mundo, que ha dado a su Hijo unigénito, para que todo aquel que en él cree no se pierda, mas tenga vida eterna");
                    break;
                case "2":
                    Reference ref2 = new Reference("Salmos", 23, 1);
                    selectedScripture = new Scripture(ref2, "Jehová es mi pastor; nada me faltará");
                    break;
                case "quit":
                    running = false;
                    Console.WriteLine("GoodBye");
                    continue;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    continue;
            }

            if (selectedScripture != null)
            {
                RunMemorizer(selectedScripture);
            }
        }
    }
    static void RunMemorizer(Scripture scripture)
    {
        string input = "";
        while (input != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            input = Console.ReadLine();

            if (input != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}