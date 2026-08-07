using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.Clear();
            DisplayPlayerInfo();

            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.Write("\nSelect a choice: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        CreateGoal();
                        break;

                    case 2:
                        ListGoalDetails();
                        break;

                    case 3:
                        SaveGoals();
                        break;

                    case 4:
                        LoadGoals();
                        break;

                    case 5:
                        RecordEvent();
                        break;

                    case 6:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        Pause();
                        break;
                }
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("        ETERNAL QUEST");
        Console.WriteLine("=================================");
        Console.WriteLine($"Score : {_score}");
        Console.WriteLine($"Level : {GetPlayerLevel()}");
        Console.WriteLine("=================================");
    }

    public void CreateGoal()
    {
        Console.Clear();

        Console.WriteLine("Goal Types");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Choose goal type: ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Goal Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                break;

            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;

            case 3:
                Console.Write("Target Count: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Bonus Points: ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(
                    name,
                    description,
                    points,
                    target,
                    bonus));
                break;
        }

        Console.WriteLine("\nGoal created successfully!");
        Pause();
    }

    public void ListGoalDetails()
    {
        Console.Clear();

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
        }
        else
        {
            Console.WriteLine("Goals:");

            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }

        Pause();
    }

    public void RecordEvent()
    {
        Console.Clear();

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            Pause();
            return;
        }

        Console.WriteLine("Select Goal:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("\nChoice: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int earned = _goals[index].RecordEvent();

            _score += earned;

            Console.WriteLine($"\nYou earned {earned} points!");
            Console.WriteLine($"Total Score: {_score}");
        }

        Pause();
    }

    public void SaveGoals()
    {
        Console.Clear();

        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
        Pause();
    }

    public void LoadGoals()
    {
        Console.Clear();

        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            Pause();
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] firstSplit = lines[i].Split(':');

            string type = firstSplit[0];
            string[] data = firstSplit[1].Split(',');

            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(
                        data[0],
                        data[1],
                        int.Parse(data[2]),
                        bool.Parse(data[3])));
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(
                        data[0],
                        data[1],
                        int.Parse(data[2])));
                    break;

                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(
                        data[0],
                        data[1],
                        int.Parse(data[2]),
                        int.Parse(data[5]),
                        int.Parse(data[3]),
                        int.Parse(data[4])));
                    break;
            }
        }

        Console.WriteLine("Goals loaded successfully.");
        Pause();
    }

    private string GetPlayerLevel()
{
        if (_score >= 10000)
            return "🌟 Eternal Hero";

        if (_score >= 7000)
            return "👑 Saint";

        if (_score >= 4000)
            return "⚔️ Elder";

        if (_score >= 2000)
            return "🥈 Disciple";

        if (_score >= 1000)
            return "🥉 Follower";

        return "🌱 Beginner";
    }

    private void Pause()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}