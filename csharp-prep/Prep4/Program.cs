using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int newNumber = 1;
        while (newNumber != 0)
        {
            Console.WriteLine("Enter a number: ");
            newNumber = int.Parse(Console.ReadLine());
            numbers.Add(newNumber);
        }

        Console.WriteLine($"The sum of the numbers is {numbers.Sum()}");
        Console.WriteLine($"The average of the numbers is {numbers.Average()}");
        Console.WriteLine($"The largest number is {numbers.Max()}");
    }
}