using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Goals
{

    private static List<Goal> goals = new List<Goal>();
    private static int userScore = 0;

    public static void CreateNewGoal()
    {
        Console.WriteLine("The Type of goals are:");
        Console.WriteLine("1. Simple Goals");
        Console.WriteLine("2. Eternal Goals");
        Console.WriteLine("3. Check List Goals");
        Console.WriteLine("What type of goal would you like to create?");
        
        string goalType = Console.ReadLine();
        Console.WriteLine("Enter the name of the goal:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the description of the goal:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter the points for the goal:");
        int points = int.Parse(Console.ReadLine());

       
        if (goalType == "1")
        {
            goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalType == "2")
        {
            goals.Add(new EternalGoal(name,description, points));
        } 
        else if (goalType == "3")
        {
            Console.WriteLine("Enter the target count:");
            int targetCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the bonus points:");
            int bonusPoints = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
        }
    }
    public static int RecordEvent()
    {
        ListGoals();
        Console.WriteLine("Enter the number of the goal to record:");
        int goalNumber = int.Parse(Console.ReadLine());
        if (goalNumber < 1 || goalNumber > goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return userScore;
        }
        if (goals[goalNumber - 1].IsComplete)
        {
            Console.WriteLine("Goal already completed.");
            return userScore;
        }
        goals[goalNumber - 1].RecordEvent();
        userScore += goals[goalNumber - 1].Points;
        return userScore;
    }
    public static void ListGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetGoalStatus()} {goals[i].Type} -{goals[i].Name} -{goals[i].Description} -{goals[i].Points} points");
        }
    }
    public static void SaveGoals()
    {
        Console.WriteLine("Enter the name of the file to save:");
        string fileName = Console.ReadLine();
        var options = new JsonSerializerOptions { WriteIndented = true };
        var jsonString = JsonSerializer.Serialize(new { Goals = goals, Score = userScore }, options);
        File.WriteAllText(fileName, jsonString);
        Console.WriteLine($"Goals and score saved to {fileName}.");
    }

    public static int LoadGoals()
    {
        Console.WriteLine("Enter the name of the file to load:");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            var jsonString = File.ReadAllText(filename);
            using JsonDocument document = JsonDocument.Parse(jsonString);
            JsonElement root = document.RootElement;

            // Accessing properties
            int score = root.GetProperty("Score").GetInt32();
            Console.WriteLine(score);
            userScore += score;
            
            JsonElement Goals = root.GetProperty("Goals");

            foreach (JsonElement goal in Goals.EnumerateArray())
            {
                if (goal.GetProperty("Type").GetString() == "Simple")
                {
                    goals.Add(new SimpleGoal(goal.GetProperty("Name").GetString(), goal.GetProperty("Description").GetString(), goal.GetProperty("Points").GetInt32(), goal.GetProperty("IsComplete").GetBoolean()));

                }
                else if (goal.GetProperty("Type").GetString() == "Eternal")
                {
                    goals.Add(new EternalGoal(goal.GetProperty("Name").GetString(), goal.GetProperty("Description").GetString(), goal.GetProperty("Points").GetInt32(), goal.GetProperty("IsComplete").GetBoolean()));
                }
                else if (goal.GetProperty("Type").GetString() == "Checklist")
                {
                    goals.Add(new ChecklistGoal(goal.GetProperty("Name").GetString(), goal.GetProperty("Description").GetString(), goal.GetProperty("Points").GetInt32(), goal.GetProperty("TargetCount").GetInt32(), goal.GetProperty("BonusPoints").GetInt32(), goal.GetProperty("IsComplete").GetBoolean()));
                }
            }
            Console.WriteLine("Goals and score loaded.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
        return userScore;
    }

}