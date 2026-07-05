using System;

class Program
{
    static void Main(string[] args)
    {

        {
            Console.WriteLine("Hello World! This is the Exercise3 Project.");

            // INSTRUCTIONS/NOTES: By default, the program runs the PART 3.
            
            //  To run the program for PART 1 only, if commented, uncomment the code for part 1 
            // and comment out the code for the other PARTs (2 and 3).

            // To run the program for PART 2, if commented, uncomment the code for part 2 and part 1.
            // while commenting out the code for part 3.

            // To run the program for PART 3, if commented, uncomment the code for part 3.
            // comment out the code for the other parts (1 and 2). 

            // Author: Godswill Moses Ikpotokin (www.ikpotokin.ng)
            // CEO and Software Developer at Applinet Technology, Nigeria (www.applinet.com.ng)
            // BYU-Pathway Worldwide

            //// PART 1: User specifies the magic number
            // Console.Write("What is the magic number? ");
            // int magicNumber = int.Parse(Console.ReadLine()!);

            // Console.Write("What is your guess? ");
            // int guess = int.Parse(Console.ReadLine()!);


            ////PART 2: User guesses the magic number until they get it right
            // while (guess != magicNumber)
            // {
            //     if (guess < magicNumber)
            //     {
            //         Console.WriteLine("Higher");
            //     }
            //     else if (guess > magicNumber)
            //     {
            //         Console.WriteLine("Lower");
            //     }

            //     Console.Write("What is your guess? ");
            //     guess = int.Parse(Console.ReadLine()!);
            // }

            // Console.WriteLine("You guessed it!");


            //// PART 3: User guesses the magic number (USING Random 1-100) until they get it right, 
            // and the program counts the number of guesses
        
            Random random = new Random();

            string playAgain = "yes";

            while (playAgain.ToLower() == "yes")
            {
                int magicNumber = random.Next(1, 101);

                int guess = 0;
                int guessCount = 0;

                while (guess != magicNumber)
                {
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());

                    guessCount++;

                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                        Console.WriteLine($"It took you {guessCount} guess(es).");
                    }
                }

                Console.Write("Would you like to play again? (yes/no): ");
                playAgain = Console.ReadLine().Trim().ToLower();
                Console.WriteLine();
            }

            Console.WriteLine("Thanks for playing!");
        }


    }
}
