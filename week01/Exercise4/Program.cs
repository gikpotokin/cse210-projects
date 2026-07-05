using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        // INSTRUCTIONS/NOTES: By default, the program runs PART 4.
        // To run the program for PART 1 only, uncomment PART 1
        // and comment out PARTS 2, 3, and 4.

        // To run the program for PART 2, uncomment PARTS 1 and 2
        // while commenting out PARTS 3 and 4.

        // To run the program for PART 3, uncomment PARTS 1, 2, and 3
        // while commenting out PART 4.

        // To run the Stretch Challenge, uncomment PART 4 only
        // and comment out PARTS 1, 2, and 3.

        // Author: GMI (www.ikpotokin.ng)
        // CEO and Software Developer at Applinet Technology, Nigeria (www.applinet.com.ng)
        // BYU-Pathway Worldwide


        
        // PART 1: Ask the user for numbers and store them in a list
        
        // List<int> numbers = new List<int>();

        // Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // int number = -1;

        // while (number != 0)
        // {
        //     Console.Write("Enter number: ");
        //     number = int.Parse(Console.ReadLine()!);

        //     if (number != 0)
        //     {
        //         numbers.Add(number);
        //     }
        // }


        // PART 2: Compute the sum and average

        // int sum = 0;

        // foreach (int item in numbers)
        // {
        //     sum += item;
        // }

        // double average = (double)sum / numbers.Count;

        // Console.WriteLine($"The sum is: {sum}");
        // Console.WriteLine($"The average is: {average}");


        // PART 3: Find the largest number

        // int largest = numbers[0];

        // foreach (int item in numbers)
        // {
        //     if (item > largest)
        //     {
        //         largest = item;
        //     }
        // }

        // Console.WriteLine($"The largest number is: {largest}");



        
        // PART 4 (Stretch Challenge)
        // Finds:
        // 1. Sum
        // 2. Average
        // 3. Largest number
        // 4. Smallest positive number
        // 5. Displays the sorted list

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine()!);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;

        foreach (int item in numbers)
        {
            sum += item;
        }

        double average = (double)sum / numbers.Count;

        int largest = numbers[0];

        foreach (int item in numbers)
        {
            if (item > largest)
            {
                largest = item;
            }
        }

        int smallestPositive = int.MaxValue;

        foreach (int item in numbers)
        {
            if (item > 0 && item < smallestPositive)
            {
                smallestPositive = item;
            }
        }

        numbers.Sort();

        Console.WriteLine();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        Console.WriteLine("The sorted list is:");

        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}