using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"What is your Grade percentage?");
        float userGrade = float.Parse(Console.ReadLine());
        string letter = "";

        if (userGrade >= 90)
        {
            letter = "A";
        }
        else if (userGrade >= 80)
        {
            letter = "B";
        }
        else if (userGrade >= 70)
        {
            letter = "C";
        }
        else if (userGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"You got a {letter}");
        if (userGrade >= 70)
        {
            Console.WriteLine($"You passed the class");
        }
        else
        {
            Console.WriteLine($"You failed the class");
        }
        
    }
}