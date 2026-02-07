using System;

public class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        Console.WriteLine();

        MathAssignment math1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-9");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment write1 = new WritingAssignment("Alexis Sanchez", "The tries","All tries");
        Console.WriteLine(write1.GetWritingInformation());




    }
}
