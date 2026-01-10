using System;

class Program
{
    static void Main(string[] args)
    {
        string Cont;
        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0,101);
            Console.WriteLine("Guess the magic number (0-100)! ");
  
            int guess = -1;
            while (guess != number)
            {
                Console.WriteLine("What is your guess? ");
                string response = Console.ReadLine();
                guess = int.Parse(response);

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine("Do you want to play again? (yes/no): ");
            Cont = Console.ReadLine().ToLower();

        } while (Cont == "yes");
        
    }
}