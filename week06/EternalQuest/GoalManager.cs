using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
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
        bool quit = false;
        while (!quit)
        {
            // Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to display."); 
        }
        else
        {
            Console.WriteLine("The goals are:");
           foreach (Goal goal in _goals)
            {
               if (goal.IsComplete())
                {
                    Console.Write("[X] ");
                }
                else
                {
                    Console.Write("[ ] ");
                }
                Console.WriteLine(goal.GetDetailsString());
           }
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        switch (goalType)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal not created.");
                break;
        }
    }
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goal, create one before");
        }
        else
        {
            Console.WriteLine("The goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
            Console.Write("Which goal did you accomplish? ");
            int choice = int.Parse(Console.ReadLine());
            if (choice < 1 || choice > _goals.Count)
            {
                Console.WriteLine("Invalid choice.");
                return;
            }
            Goal selectedGoal = _goals[choice - 1];
            selectedGoal.RecordEvent();
            if (selectedGoal.IsComplete())
            {
                _score += selectedGoal._points;
                if (selectedGoal is ChecklistGoal checklistGoal)
                {
                    _score += checklistGoal._bonus;
                }
            }
            else
            {
                Console.WriteLine("Event recorded.");
                _score += selectedGoal._points;
            }
        }
    }
    public void SaveGoals()
    {
        Console.Write("Enter the filename to save goals: ");
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
    }
    public void LoadGoals()
    {
        Console.Write("Enter the filename to load goals: ");
        string filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }
        else
        {
            Console.WriteLine("File loaded successfully.");
            List<string> List1 = File.ReadAllLines(filename).ToList();
            int lg = List1.Count;
            _score = int.Parse(List1[0]);
            _goals.Clear();
            for (int i = 1; i < lg; i++)
            {
                string line = List1[i];
                string[] parts = line.Split(':');
                string goalType = parts[0];
                string[] attributes = parts[1].Split(',');
                switch (goalType)
                {
                    case "SimpleGoal":
                        string sName = attributes[0];
                        string sDesc = attributes[1];
                        int sPoints = int.Parse(attributes[2]);
                        bool sIsComplete = bool.Parse(attributes[3]);
                        SimpleGoal simpleGoal = new SimpleGoal(sName, sDesc, sPoints);

                        if (sIsComplete)
                        {
                            simpleGoal.GetIsComplete(); // Mark as complete
                        }
                        _goals.Add(simpleGoal);
                        break;
                    case "EternalGoal":
                        string eName = attributes[0];
                        string eDesc = attributes[1];
                        int ePoints = int.Parse(attributes[2]);
                        EternalGoal eternalGoal = new EternalGoal(eName, eDesc, ePoints);
                        _goals.Add(eternalGoal);
                        break;
                    case "ChecklistGoal":
                        string cName = attributes[0];
                        string cDesc = attributes[1];
                        int cPoints = int.Parse(attributes[2]);
                        int cTarget = int.Parse(attributes[3]);
                        int cBonus = int.Parse(attributes[4]);
                        int cAmountCompleted = int.Parse(attributes[5]);
                        
                        ChecklistGoal checklistGoal = new ChecklistGoal(cName, cDesc, cPoints, cTarget, cBonus);
                        checklistGoal.GetAmountCompleted(cAmountCompleted);
                        _goals.Add(checklistGoal);
                        break;
                    default:
                        Console.WriteLine($"Unknown goal type: {goalType}");
                        break;
                }
            }
        }
        
    }



}