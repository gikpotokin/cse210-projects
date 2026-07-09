using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World! This is the Resumes Project.");
        // INSTRUCTIONS/NOTES:
        // This program demonstrates the principle of abstraction by creating
        // separate classes to represent a person's resume and job history.
        // It creates Job objects, stores them in a Resume object, and displays
        // the resume information in a clean and organized format.
        //
        // Author: Godswill Moses Ikpotokin (www.ikpotokin.ng)
        // CEO and Software Developer at Applinet Technology, Nigeria (www.applinet.com.ng)
        // Student at BYU-Pathway Worldwide

        // Jobs
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Resume
        Resume myResume = new Resume();
        myResume._name = "Godswill Moses Ikpotokin";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}