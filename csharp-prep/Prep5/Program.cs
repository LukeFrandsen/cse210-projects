using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        String UserName = PromtUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResults(UserName, squaredNumber);

        // Console.WriteLine("Hello Prep5 World!");
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static String PromtUserName()
        {
            Console.WriteLine($"What is your name?");
            String name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.WriteLine($"What is your favorite number?");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquareNumber(int number)
        {
            int squaredNumber = number * number;
            // Console.WriteLine($"{squaredNumber}");
            return squaredNumber;
        }
        static void DisplayResults(String name, int squaredNumber)
        {
            Console.WriteLine($"{name} the square of your number is {squaredNumber}");
        }
    }
}