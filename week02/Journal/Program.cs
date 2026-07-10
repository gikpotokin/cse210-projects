using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");


        // INSTRUCTIONS/NOTES:
        //
        // This program demonstrates the principle of abstraction by using separate
        // classes for the main parts of a journal application.
        //
        // - Program.cs handles the menu and user interaction.
        // - Journal.cs manages journal entries.
        // - Entry.cs stores the date, prompt, and response for each entry.
        // - PromptGenerator.cs provides a random writing prompt.
        //
        // Features:
        // • Write a new journal entry.
        // • Display all journal entries.
        // • Save entries to a file.
        // • Load entries from a file.
        //
        // Author: Godswill Moses Ikpotokin (https://www.ikpotokin.ng)
        // CEO & Software Developer, Applinet Technology (https://www.applinet.com.ng)
        // Student, BYU-Pathway Worldwide

        Journal journal = new Journal();
        PromptGenerator prompts = new PromptGenerator();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Search Entries");
            Console.WriteLine("6. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = prompts.GetRandomPrompt();

                    Console.WriteLine();
                    Console.WriteLine(prompt);
                    Console.Write("> ");

                    string response = Console.ReadLine();

                    Console.Write("Mood today: ");
                    string mood = Console.ReadLine();

                    Entry entry = new Entry(prompt, response, mood);

                    journal.AddEntry(entry);

                    Console.WriteLine("Journal entry saved.");
                    break;

                case "2":
                    journal.Display();
                    break;

                case "3":
                    Console.Write("Filename: ");
                    journal.Save(Console.ReadLine());
                    break;

                case "4":
                    Console.Write("Filename: ");
                    journal.Load(Console.ReadLine());
                    break;

                case "5":
                    Console.Write("Enter keyword: ");
                    journal.Search(Console.ReadLine());
                    break;

                case "6":
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}