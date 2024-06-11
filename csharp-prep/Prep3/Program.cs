using System;

class Program
{
    static void Main(string[] args)
    {

        // Console.WriteLine("What is the magic number?");
        // int magicNumber = int.Parse(Console.ReadLine());
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        Console.WriteLine("What is your guess for the magic number?");
        int magicNumerGuess = int.Parse(Console.ReadLine());
        while (magicNumber != magicNumerGuess)
        { 
            if (magicNumerGuess > magicNumber)
        {
            Console.WriteLine("Your guess is too high");
        }
        else if (magicNumerGuess < magicNumber)
        {
            Console.WriteLine("Your guess is too low");
        }
            Console.WriteLine("What is your new guess for the magic number?");
            magicNumerGuess = int.Parse(Console.ReadLine());
            if (magicNumber == magicNumerGuess)
            {
                Console.WriteLine("You guessed the magic number!");
            }

        }
        
    }
}