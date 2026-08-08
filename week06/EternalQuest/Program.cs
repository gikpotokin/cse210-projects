using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        
        // INSTRUCTIONS/NOTES:
        //
        // The Eternal Quest program demonstrates the principles of object-oriented
        // programming, including abstraction, encapsulation, inheritance, and
        // polymorphism.
        //
        // The Goal class contains common properties and behaviors shared by all
        // goal types. SimpleGoal, EternalGoal, and ChecklistGoal inherit from Goal
        // and override methods to provide their own specific behaviors.
        //
        // GoalManager manages the application's goals, menu options, score,
        // events, and saving/loading functionality.
        //
        // Polymorphism is demonstrated by storing different goal types in a
        // List<Goal> and calling methods such as RecordEvent() and
        // GetDetailsString() through the Goal base class.
        //
        // Author: Godswill Moses Ikpotokin
        // CEO & Software Developer, Applinet Technology
        // Student, BYU-Pathway Worldwide

        Console.Title = "Eternal Quest";

        GoalManager manager = new GoalManager();

        manager.Start();
    }
}