public class Menu : Goals
{
    Goals goals = new Goals();
    private int points { get; set; }
    public void DisplayMenu()
    {
        while (true)
        {
            
            Console.WriteLine($"You have {points} points");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Activity");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateNewGoal();
            }
            else if (choice == "2")
            {
                ListGoals();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                points = LoadGoals();
            }
            else if (choice == "5")
            {
                
                points = RecordEvent();
            }
            else if (choice == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
            }
        }
    }
}
