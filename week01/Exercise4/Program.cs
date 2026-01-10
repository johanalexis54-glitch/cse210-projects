using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // Doing List
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<float> NumberList = new List<float>();
        float ENum;
        
        do
        {
            Console.Write("Enter number: ");
            string EnterNumber = Console.ReadLine();
            ENum = float.Parse(EnterNumber);

            if (ENum != 0)
            {
                NumberList.Add(ENum);
            }
        } while (ENum != 0);

        
        // variable necesary for calculates.
        float Sum = 0;
        float Max = -999999999999999999;
        float Min = 9999999999999999;
        

        foreach (float number in NumberList)
        {
            //Calculate Sum
            Sum += number;

            //Calculate Max
            if (number > Max)
            {
                Max = number;
            }

            // Calculate Min
            if (number < Min && number > 0)
            {
                Min = number;
            }

        }

        // Calculate Average
        float average = Sum / NumberList.Count;


        // Print Sum
        Console.WriteLine($"The sum is: {Sum}");
        // Print Average
        Console.WriteLine($"The average is: {average}");
        // Print Max
        Console.WriteLine($"The largest number is: {Max} ");
        // Print Min
        Console.WriteLine($"The smallest positive number is: {Min} ");

        // The order List
        NumberList.Sort();
        Console.WriteLine($"The sorted list is: ");
        foreach (float number in NumberList)
        {
            Console.WriteLine(number);            
        }

    }
}