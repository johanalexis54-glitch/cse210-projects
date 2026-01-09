using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string Grade = Console.ReadLine();
        int GradeN = int.Parse(Grade);
        string score = "";
        int LastDigit = GradeN % 10;
        if (LastDigit == 7)
        {
            score = "+";
        }
        else if (LastDigit == 3)
        {
            score = "-";
        }
        else
        {
            score = "";
        }

        if (GradeN >= 90)
        {
           if (LastDigit == 7)
            {
                Console.WriteLine($"Your Grade is A"); 
            }
            else
            {
                Console.WriteLine($"Your Grade is A{score}"); 
            }
        }
        else if (GradeN < 90 && GradeN >= 80)
        {
            Console.WriteLine($"Your Grade is B{score}"); 
        }
        else if (GradeN < 80 && GradeN >= 70)
        {
            Console.WriteLine($"Your Grade is C{score}"); 
        }
        else if (GradeN < 70 && GradeN >= 60)
        {
            Console.WriteLine($"Your Grade is D{score}"); 
        }
        else
        {
            if (LastDigit == 7 || LastDigit == 3)
            {
                Console.WriteLine($"Your Grade is F");
            }
            else
            {
                Console.WriteLine($"Your Grade is F{score}");
            }
        }

    }
}