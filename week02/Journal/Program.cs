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
        // EXCEEDING REQUIREMENTS
        //
        // This project exceeds the core requirements by:
        //
        // 1. Saving and loading journal entries using JSON serialization
        //    instead of a plain text file.
        //
        // 2. Recording both the current date and time for every entry.
        //
        // 3. Allowing users to record their mood with each journal entry.
        //
        // 4. Providing a keyword search feature that searches prompts,
        //    responses, and moods.
        //
        // 5. Using exception handling to gracefully handle file errors.
        //
        // Author: Godswill Moses Ikpotokin
        // CEO & Software Developer, Applinet Technology
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

            string choice = Console.ReadLine()?.Trim() ?? "";

            switch (choice)
            {
                case "1":
                {
                    string prompt = prompts.GetRandomPrompt();

                    Console.WriteLine();
                    Console.WriteLine(prompt);
                    Console.WriteLine("(Type 'cancel' at any time to return to the main menu.)");

                    string response = "";
                    bool cancelled = false;

                    while (true)
                    {
                        Console.Write("> ");
                        response = Console.ReadLine()?.Trim() ?? "";

                        if (response.Equals("cancel", StringComparison.OrdinalIgnoreCase))
                        {
                            cancelled = true;
                            Console.WriteLine("Journal entry cancelled.");
                            break;
                        }

                        if (!string.IsNullOrWhiteSpace(response))
                        {
                            break;
                        }

                        Console.WriteLine("Response cannot be empty. Please try again.");
                    }

                    if (cancelled)
                    {
                        break;
                    }

                    string mood = "";

                    // Get mood
                    while (true)
                    {
                        Console.Write("Mood today: ");
                        mood = Console.ReadLine()?.Trim() ?? "";

                        if (mood.Equals("cancel", StringComparison.OrdinalIgnoreCase))
                        {
                            cancelled = true;
                            Console.WriteLine("Journal entry cancelled.");
                            break;
                        }

                        if (!string.IsNullOrWhiteSpace(mood))
                        {
                            break;
                        }

                        Console.WriteLine("Mood cannot be empty. Please try again.");
                    }

                    if (cancelled)
                    {
                        break;
                    }

                    Entry entry = new Entry(prompt, response, mood);
                    journal.AddEntry(entry);

                    Console.WriteLine("Journal entry saved successfully.");
                    break;
                }

                case "2":
                    journal.Display();
                    break;

                case "3":
                {
                    Console.Write("Filename: ");
                    string saveFile = Console.ReadLine()?.Trim() ?? "";

                    if (string.IsNullOrWhiteSpace(saveFile))
                    {
                        Console.WriteLine("Filename cannot be empty.");
                    }
                    else
                    {
                        journal.Save(saveFile);
                    }

                    break;
                }

                case "4":
                {
                    Console.Write("Filename: ");
                    string loadFile = Console.ReadLine()?.Trim() ?? "";

                    if (string.IsNullOrWhiteSpace(loadFile))
                    {
                        Console.WriteLine("Filename cannot be empty.");
                    }
                    else
                    {
                        journal.Load(loadFile);
                    }

                    break;
                }

                case "5":
                {
                    Console.Write("Enter keyword: ");
                    string keyword = Console.ReadLine()?.Trim() ?? "";

                    if (string.IsNullOrWhiteSpace(keyword))
                    {
                        Console.WriteLine("Keyword cannot be empty.");
                    }
                    else
                    {
                        journal.Search(keyword);
                    }

                    break;
                }

                case "6":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 6.");
                    break;
            }
        }
    }
}