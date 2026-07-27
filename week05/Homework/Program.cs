using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        // INSTRUCTIONS/NOTES:
        // 
        // The program demonstrates code reuse through inheritance, where the
        // derived classes inherit common data and behavior from the Assignment
        // class while adding their own  properties and methods.
        //
        // Author: Godswill Moses Ikpotokin
        // CEO & Software Developer, Applinet Technology
        // Student, BYU-Pathway Worldwide

    
        MathAssignment math = new MathAssignment(
            "Roberto Rodriguez",
            "Fractions",
            "7.3",
            "8-19");

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writing = new WritingAssignment(
            "Mary Waters",
            "European History",
            "The Causes of World War II");

        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}