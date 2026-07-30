using System;
using System.Collections.Generic;

class Program
{
    private static List<string> _sessionHistory = new List<string>();

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        // Creativity and Exceeding Requirements:
        // In addition to the core requirements, this program includes a
        // session history feature. After completing an activity, the program
        // records the activity name, duration, and completion time. Users can
        // select the "View Session History" option to review their completed
        // mindfulness sessions.
        // Author: Godswill Moses Ikpotokin
        // CEO & Software Developer, Applinet Technology
        // Student, BYU-Pathway Worldwide


        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. View Session History");
            Console.WriteLine("  5. Quit");
            Console.WriteLine();

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    StartBreathingActivity();
                    break;

                case "2":
                    StartReflectingActivity();
                    break;

                case "3":
                    StartListingActivity();
                    break;

                case "4":
                    DisplaySessionHistory();
                    break;

                case "5":
                    running = false;
                    Console.WriteLine();
                    Console.WriteLine(
                        "Thank you for using the Mindfulness Program."
                    );
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine(
                        "Invalid choice. Please select an option from 1 to 5."
                    );
                    PauseBeforeReturningToMenu();
                    break;
            }
        }
    }

    // Starts the Breathing Activity.
    static void StartBreathingActivity()
    {
        BreathingActivity activity = new BreathingActivity();

        activity.Run();

        AddSessionToHistory(
            "Breathing Activity",
            activity.GetActivityDuration()
        );

        PauseBeforeReturningToMenu();
    }

    // Starts the Reflecting Activity.
    static void StartReflectingActivity()
    {
        ReflectingActivity activity = new ReflectingActivity();

        activity.Run();

        AddSessionToHistory(
            "Reflecting Activity",
            activity.GetActivityDuration()
        );

        PauseBeforeReturningToMenu();
    }

    // Starts the Listing Activity.
    static void StartListingActivity()
    {
        ListingActivity activity = new ListingActivity();

        activity.Run();

        AddSessionToHistory(
            "Listing Activity",
            activity.GetActivityDuration()
        );

        PauseBeforeReturningToMenu();
    }

    // Adds a completed activity to the session history.
    static void AddSessionToHistory(string activityName, int duration)
    {
        string session =
            $"{DateTime.Now:g} - {activityName} - {duration} seconds";

        _sessionHistory.Add(session);
    }

    // Displays all completed mindfulness sessions.
    static void DisplaySessionHistory()
    {
        Console.Clear();

        Console.WriteLine("Mindfulness Session History");
        Console.WriteLine();

        if (_sessionHistory.Count == 0)
        {
            Console.WriteLine(
                "No mindfulness activities have been completed yet."
            );
        }
        else
        {
            for (int i = 0; i < _sessionHistory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_sessionHistory[i]}");
            }
        }

        PauseBeforeReturningToMenu();
    }

    // Pauses before returning to the main menu.
    static void PauseBeforeReturningToMenu()
    {
        Console.WriteLine();
        Console.WriteLine(
            "Press Enter to return to the main menu."
        );
        Console.ReadLine();
    }
}