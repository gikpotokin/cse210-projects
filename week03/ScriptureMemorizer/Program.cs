using System;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static Random random = new Random();


    static void Main(string[] args)
    {

        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // INSTRUCTIONS/NOTES:
        //
        // This program demonstrates the principle of encapsulation by using separate
        // classes to represent the main parts of a scripture memorization application.
        //
        // - Program.cs controls the program flow, user interaction, and menu logic.
        // - Scripture.cs manages the scripture, including its reference, list of words,
        //   displaying the scripture, and hiding random words.
        // - Reference.cs stores the scripture reference (book, chapter, verse, or verse range)
        //   and formats it for display.
        // - Word.cs represents an individual word in the scripture, stores its hidden/shown
        //   state, and controls how the word is displayed.
        // - Scriptures are loaded from a text file, and one is selected at random each time
        //   the program starts.
        

        // EXCEEDING REQUIREMENTS
        // 1. Scriptures are loaded from a file.
        // 2. A random scripture is selected.
        // 3. Only visible words are hidden.
        // 4. Between 2 and 4 words are hidden each turn.

        // Author: Godswill Moses Ikpotokin
        // CEO & Software Developer, Applinet Technology
        // Student, BYU-Pathway Worldwide


        List<Scripture> scriptures = LoadScriptures();

        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
                break;

            Console.WriteLine();
            Console.Write("Press ENTER to continue or type 'quit': ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(random.Next(2, 5));
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nProgram finished.");
    }

    static List<Scripture> LoadScriptures()
    {
        List<Scripture> scriptures = new List<Scripture>();

        foreach (string line in File.ReadAllLines("scriptures.txt"))
        {
            string[] parts = line.Split('|');

            Reference reference;
            string text;

            if (parts.Length == 4)
            {
                reference = new Reference(
                    parts[0],
                    int.Parse(parts[1]),
                    int.Parse(parts[2]));

                text = parts[3];
            }
            else
            {
                reference = new Reference(
                    parts[0],
                    int.Parse(parts[1]),
                    int.Parse(parts[2]),
                    int.Parse(parts[3]));

                text = parts[4];
            }

            scriptures.Add(new Scripture(reference, text));
        }

        return scriptures;
    }
}