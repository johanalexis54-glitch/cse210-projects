using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        // Welcome
        static void DisplayPersonalMessage()
        {
            Console.WriteLine("Welcome to the program!");
        } DisplayPersonalMessage();

        // Enter Name and save name.
        static string UserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;    
        }

        // Enter the number
        static float FNumber()
        {
            Console.Write("Please enter your favorit number: ");
            string numbers = Console.ReadLine();
            float number = float.Parse(numbers);
            float square = number * number;
            return square;
        }
        Console.WriteLine(UserName() + ", the square of your number is " + FNumber());

    }
}