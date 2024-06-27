using System;

class Program
{
    static void Main(string[] args)
    {
        
        Reference myReference = new Reference();
        Scripture scripture = new Scripture();
        Verse myVerse = scripture.GetVerse();

        Console.Clear();
        Console.WriteLine($"{myReference.GetReference()}");
        myVerse.DisplayVerse();
        Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
        
        while (myVerse.GetCount() > 0)
        {
            string blank = Console.ReadLine();
            if (blank == "")
            {
                if (myVerse.GetCount() == 1)
                {
                    Console.WriteLine("You have completed the verse!");
                    break;
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine($"{myReference.GetReference()}");
                    myVerse.hideWords();
                    myVerse.DisplayVerse();
                    Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
                }
            }
            else if ( blank == "quit")
            {
                break;
            }
        }

        
    }
}