using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");

        List<Goal> listGoals = new List<Goal>();

        int totalPoints = 0, option = 0, level = 1;

        while (option != 6)
        {
            option = Menu(totalPoints);

            switch (option)
            {
                case 1:
                    // Create new goal
                    listGoals = NewGoal(listGoals);
                    break;

                case 2:
                    // List goals
                    DisplayListGoals(listGoals);
                    Console.WriteLine("\nPress enter when you're done.");
                    Console.ReadLine();
                    break;

                case 3:
                    // Save goals
                    SaveFile(listGoals, totalPoints);
                    break;

                case 4:
                    // Load goals
                    LoadFile(out totalPoints, out listGoals);

                    // Levels system.
                    level = LevelUp(totalPoints, level);
                    break;

                case 5:
                    // Record event
                    totalPoints = RecordEvent(listGoals, totalPoints);

                    // Levels system.
                    level = LevelUp(totalPoints, level);
                    break;

                default:
                    break;
            }
        }
    }

    static int Menu(int totalPoints)
    {
        // Display the Menu and the total points.
        Console.Clear();

        Console.WriteLine($"You have {totalPoints} points\n");

        Console.WriteLine("Menu Options:");
        Console.WriteLine("> 1. Create new goal");
        Console.WriteLine("> 2. List goals");
        Console.WriteLine("> 3. Save goals");
        Console.WriteLine("> 4. Load goals");
        Console.WriteLine("> 5. Record event");
        Console.WriteLine("> 6. Quit");

        Console.Write("Select a choice from the menu: ");

        return int.Parse(Console.ReadLine());
    }
    static List<Goal> NewGoal(List<Goal> listGoals)
    {
        // Option 1: Create new goal.
        string typeGoal = "Error";
        while (typeGoal == "Error")
        {
            typeGoal = SelectTypeGoal();
        }

        Console.Write("\nWhat is the name? ");
        string name = Console.ReadLine();
        Console.Write("\nWhat is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("\nAmount of points associated? ");
        int points = int.Parse(Console.ReadLine());

        int totalTimes = 0, bonusPoints = 0;

        if (typeGoal == "Checklist Goal")
        {
            Console.Write("\nHow many times does this goal need to be accomplished for a bonus? ");
            totalTimes = int.Parse(Console.ReadLine());
            Console.Write("\nWhat is the bonus for accomplishing it that many times? ");
            bonusPoints = int.Parse(Console.ReadLine());
        }

        listGoals.Add(CreateGoal(typeGoal, name, description, points, bonusPoints, totalTimes));
        return listGoals;
    }
    // Stretch challengue: Levels into the gamification.
        // There is a level-system in the program, and when the user earns a certain
        // number of points, the level goes up. The Level is implicitly saved in the
        // total points saved in the file.
    static double TestLevel(int level)
    {
        double basePoints = 1000, levelRate = 500;
        double nextLevelPoints = basePoints;

        for (int i = 2; i <= level; i++)
        {
            nextLevelPoints += levelRate * (int)Math.Pow(2, i - 2);
        }

        return nextLevelPoints;
    }
    static int LevelUp(int totalPoints, int level)
    {
        double nextLevelPoints = TestLevel(level);
        int copyLevel = level;
        while (totalPoints >= nextLevelPoints)
        {
            level ++;
            nextLevelPoints = TestLevel(level);
        }
        if (level != copyLevel)
        {
            WriteText(100, "Congratulations!!!");
            WriteText(100, $"You are in level {level}!");
        }
        return level;
    }
    static string SelectTypeGoal()
    {
        Console.Clear();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.Write("\nWhat type of goal would you like to create? ");
        int typeNumber = int.Parse(Console.ReadLine());

        switch (typeNumber)
        {
            case 1:
                return "Simple Goal";
            case 2:
                return "Eternal Goal";
            case 3:
                return "Checklist Goal";
            default:
                return "Error";
        }
    }
    static Goal CreateGoal(string typeGoal, string name, string description, int points, int bonusPoints = 0, int totalTimes = 0, int currentTimes = 0, bool status = false)
    {
        // Create a variable of Goal type.
        if (typeGoal == "Simple Goal")
        {
            SimpleGoal sGoal = new SimpleGoal(name, description, points, status);
            return sGoal;
        }
        else if (typeGoal == "Eternal Goal")
        {
            EternalGoal eGoal = new EternalGoal(name, description, points);
            return eGoal;
        }
        else
        {
            ChecklistGoal clGoal = new ChecklistGoal(name, description, points, bonusPoints, totalTimes, currentTimes);
            return clGoal;
        }
    }
    static void DisplayListGoals(List<Goal> listGoals)
    {
        // Option 2: Display a list of the goals.
        Console.WriteLine("\nThe goals are:");
        int i = 1;
        foreach (Goal goal in listGoals)
        {
            Console.WriteLine($"{i}. {goal.DisplayGoal()}");
            i++;
        }
    }
    static string ObtainFileName()
    {
        Console.Write("\nName of the file: ");
        return Console.ReadLine();
    }
    static void SaveFile(List<Goal> listGoals, int totalPoints)
    {
        // Option 3: Save the goals and the total points into a file.
        string fileName = ObtainFileName();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(totalPoints);
            foreach (Goal goal in listGoals)
            {
                outputFile.WriteLine(goal.SaveInfo());     
            }
        }
    }
    static void LoadFile(out int totalPoints, out List<Goal> listGoals)
    {
        // Option 4: Load the goals and the total points from a file.
        string fileName = ObtainFileName();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        List<Goal> list = new List<Goal>();

        totalPoints = int.Parse(lines[0]);
        lines = lines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");

            string goalType = parts[0];
            string[] goalData = parts[1].Split("~");

            string name = goalData[0];
            string description = goalData[1];
            int points = int.Parse(goalData[2]);

            int bonusPoints = 0, totalTimes = 0, currentTimes = 0;
            bool status = false;

            switch (goalType)
            {
                case "Simple Goal":
                    if (goalData[3] == "True")
                    {
                        status = true;
                    }
                    break;
                
                case "Checklist Goal":
                    bonusPoints = int.Parse(goalData[3]);
                    totalTimes = int.Parse(goalData[4]);
                    currentTimes = int.Parse(goalData[5]);
                    break; 
            }

            Goal newGoal = CreateGoal(goalType, name, description, points, bonusPoints, totalTimes, currentTimes, status);
            list.Add(newGoal);
        }

        listGoals = list;
    }
    static int RecordEvent(List<Goal> listGoals, int totalPoints)
    {
        // Option 5: Record event
        Console.Clear();
        DisplayListGoals(listGoals);

        Console.Write("\nWhich goal did you accomplish? ");
        int earnedPoints = listGoals[int.Parse(Console.ReadLine()) - 1].RecordEvent();

        Console.WriteLine($"\nCongratulations! You have earned {earnedPoints} points\nPress enter to continue");
        Console.ReadLine();

        return totalPoints += earnedPoints;
    }
    static void WriteText(int speed, string text)
    {
        foreach (char i in text)
        {
            Console.Write(i);
            Thread.Sleep(speed);
        }
        Console.WriteLine();
        Thread.Sleep(1000);
    }

}