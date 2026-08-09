using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        // INSTRUCTIONS/NOTES:
        //
        // The program demonstrates inheritance and polymorphism by creating
        // different types of exercise activities that share common data and
        // behavior through the Activity base class.
        //
        // The Running, Cycling, and Swimming classes inherit from Activity
        // and override the methods used to calculate distance, speed, and pace.
        // All activities are stored in the same Activity list, demonstrating
        // polymorphism when GetSummary() is called on each activity.
        //
        // Author: Godswill Moses Ikpotokin
        // CEO & Software Developer, Applinet Technology
        // Student, BYU-Pathway Worldwide
        List<Activity> activities = new List<Activity>();

        activities.Add(
            new Running(
                new DateTime(2022, 11, 3),
                30,
                3.0
            )
        );

        activities.Add(
            new Cycling(
                new DateTime(2022, 11, 3),
                60,
                15.0
            )
        );

        activities.Add(
            new Swimming(
                new DateTime(2022, 11, 3),
                30,
                20
            )
        );

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}