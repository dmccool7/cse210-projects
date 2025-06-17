using System;
using System.IO;

public class GoalManager
{
    private int _score;
    private List<Goal> _goals;
    private int _goalsCompletedCount = 0;
    private int _bonusThreshold = 10;
    private int _bonusPoints = 250;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            Console.WriteLine();
            Console.WriteLine($"You have {_score} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
        }
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nThe goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("\nWhat is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("\nWhat is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("\nWhat is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            SimpleGoal sGoal = new SimpleGoal(name, description, points);
            _goals.Add(sGoal);
        }
        else if (choice == "2")
        {
            EternalGoal eGoal = new EternalGoal(name, description, points);
            _goals.Add(eGoal);
        }
        else if (choice == "3")
        {
            Console.Write("\nHow many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("\nWhat is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal cGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(cGoal);
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("\nThe goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        int pointsEarned = _goals[goalIndex].RecordEvent();
        _score += pointsEarned;
        _goalsCompletedCount++;
        Console.Beep();
        Console.WriteLine($"\nCongratulations! You have earned {pointsEarned} points!");

        if (_goalsCompletedCount % _bonusThreshold == 0)
        {
            _score += _bonusPoints;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"You've completed {_goalsCompletedCount} goals! +{_bonusPoints} bonus points!");
            Console.ResetColor();
        }
    }

    public void SaveGoals()
    {
        Console.Write("\nWhat is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            outputFile.WriteLine(_goalsCompletedCount);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("\nWhat is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goalsCompletedCount = int.Parse(lines[1]);
        _goals.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string goalType = parts[0];

            if (goalType == "SimpleGoal")
            {
                SimpleGoal sGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                if (bool.Parse(parts[4]))
                {
                    sGoal.RecordEvent();
                }
                _goals.Add(sGoal);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal eGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(eGoal);
            }
            else if (goalType == "ChecklistGoal")
            {
                ChecklistGoal cGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[4]));
                for (int i = 0; i < int.Parse(parts[6]); i++)
                {
                    cGoal.RecordEvent();
                }
                _goals.Add(cGoal);
            }
        }
    }
}