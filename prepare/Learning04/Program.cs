using System;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment assignment = new Assignment("John", "C#");
        MathAssignment mathAssignment = new MathAssignment("1", "1-10", "Baba", "Math");
        WritingAssignment writingAssignment = new WritingAssignment("My First Writing", "Sarah", "Writing");

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomework());
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}