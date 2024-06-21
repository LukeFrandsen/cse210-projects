using System;

class Program
{
    static void Main(string[] args)
    {
        Entry prompt = new Entry();
        Journal journalEntry = new Journal("Date", "Question", "Entry");
        string menu = "";
        Console.WriteLine("Welcome to the Journal!");
        while (menu != "5")
        {
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Entry");
            Console.WriteLine("3. Save to Jounral");
            Console.WriteLine("4. Load from Journal");
            Console.WriteLine("5. Exit");
            menu = Console.ReadLine();
            if (menu == "1")
            {
                prompt.RandomPrompt();
                string entry = Console.ReadLine();
                journalEntry.AddEntry(entry);
            }
            else if (menu == "2")
            {
                Console.WriteLine(journalEntry.);
            }
            else if (menu == "3")
            {
                journalEntry.WriteToFile("journal.txt");
            }
            else if (menu == "4")
            {
                journalEntry.LoadFromFile("journal.txt");
            }
            else if (menu == "5")
            {
                Console.WriteLine("Goodbye!");
            }
        }
    
    }
}