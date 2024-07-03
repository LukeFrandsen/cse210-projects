using System;

class Program
{
    static void Main(string[] args)
    {

        Breathing breathingActivity = new Breathing();
        Reflection reflectionActivity = new Reflection();
        Listing listingActivity = new Listing();

        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine($"Menu Options? \n1. Breathing \n2. Reflection \n3. Listing \n4. Quit \nSelect an option:");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                breathingActivity.DisplayStart();
            }
            else if (choice == "2")
            {
                reflectionActivity.DisplayStart();
            }
            else if (choice == "3")
            {
                listingActivity.DisplayStart();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
        
    }
}