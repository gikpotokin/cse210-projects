using System;

class Program
{
    static void Main(string[] args)
    {
        // INSTRUCTIONS/NOTES:
        // This program demonstrates how to read user input from the console
        // and how to use string interpolation in C#.
        // 
        // author: Godswill Moses Ikpotokin (www.ikpotokin.ng)
        // CEO and Software Developer at Applinet Technology, Nigeria (www.applinet.com.ng)
        // BYU-Pathway Worldwide    

        Console.WriteLine("Please enter your first name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Please enter your last name:");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}