
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        
        // INSTRUCTIONS/NOTES:
        // This program demonstrates how to use conditional statements (if-else) in C#
        // and how to read user input from the console.
        // author: Godswill Moses Ikpotokin (www.ikpotokin.ng)
        // CEO and Software Developer at Applinet Technology, Nigeria (www.applinet.com.ng)
        // BYU-Pathway Worldwide    


        Console.Write("Please enter your grade:");
        string grade = Console.ReadLine();

        int gradeValue = int.Parse(grade);

        string letter = "";
        string sign = "";

        // A >= 90
        // B >= 80
        // C >= 70
        // D >= 60
        // F < 60

        if (gradeValue >= 90)
        {
            letter = "A";
        }
        else if (gradeValue >= 80)
        {
            letter = "B";
        }
        else if (gradeValue >= 70)
        {
            letter = "C";
        }
        else if (gradeValue >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        if (gradeValue >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep working hard. You'll do better next time!");
        }

        int lastDigit = gradeValue % 10;

        if (letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        
    }
}