// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         bool playAgain = true;

//         while (playAgain)
//         {
//             Console.WriteLine("Welcome to Guess My Number!");
//             Console.Write("Enter the magic number: ");
//             int magicNumber = int.Parse(Console.ReadLine());

//             // Initial user guess
//             int userGuess = -1;
//             int numberOfGuesses = 0;

//             // Main game loop
//             while (userGuess != magicNumber)
//             {
//                 Console.Write("Enter your guess: ");
//                 userGuess = int.Parse(Console.ReadLine());
//                 numberOfGuesses++;

//                 if (userGuess == magicNumber)
//                 {
//                     Console.WriteLine($"Congratulations! You guessed the magic number in {numberOfGuesses} guesses.");
//                 }
//                 else if (userGuess < magicNumber)
//                 {
//                     Console.WriteLine("Too low! Try guessing higher.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Too high! Try guessing lower.");
//                 }
//             }

//             // Ask the user if they want to play again
//             Console.Write("Do you want to play again? (yes/no): ");
//             string playAgainResponse = Console.ReadLine().ToLower();
//             playAgain = playAgainResponse == "yes";
//         }

//         Console.WriteLine("Thanks for playing!");
//     }
// }

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // Core Requirement 1
        Console.Write("What is the magic number?  ");
        string magicNumberInput = Console.ReadLine();


        // Convert the user input to an integer as: If conversion successful, use 'result'
        if (int.TryParse(magicNumberInput, out int magicNumber))
        {
            // Core Requirement 1: Prompt user for guess
            Console.Write("What is your guess?  ");
            string guessInput = Console.ReadLine();


            // Convert the user input to an integer as: If conversion successful, use 'result'
            if (int.TryParse(guessInput, out int userGuess))
            {
                // Compare the guess with the magic number
                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Guess Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Guess Lower");
                }
                else
                {
                    Console.WriteLine("You Guessed it!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer as your guess.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer as the magic number.");
        }

        Console.WriteLine("Core Requirement 2\n");

        // Core Requirement 2: Implement a loop for repeated guesses
        Console.Write("What is the magic number?  ");
        string magicNumberInput2 = Console.ReadLine();


        // Convert the user input to an integer as: If conversion successful, use 'result'
        if (int.TryParse(magicNumberInput2, out int magicNumber2))
        {
            // Loop terminate based on whether the user guessed the correct number
            bool guessedCorrectly = false;

            do
            {
                Console.Write("What is your guess?  ");
                string trialInput = Console.ReadLine();

                // Convert the user input to an integer
                if (int.TryParse(trialInput, out int trial))
                {
                    if (trial < magicNumber2)
                    {
                        Console.WriteLine("Guess Higher");
                    }
                    else if (trial > magicNumber2)
                    {
                        Console.WriteLine("Guess Lower");
                    }
                    else
                    {
                        Console.WriteLine("You Guessed it!");
                        guessedCorrectly = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer as your guess.");
                }

            } while (!guessedCorrectly);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer as the magic number.");
        }

        Console.WriteLine("Core Requirement 3\n");

        // Random number generation
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        {
            // Loop terminate based on whether the user guessed the correct number
            bool guessedCorrectly = false;

            do
            {
                Console.Write("What is your guess?  ");
                string trialInput = Console.ReadLine();

                // Convert the user input to an integer
                if (int.TryParse(trialInput, out int trial))
                {
                    if (trial < magicNumber2)
                    {
                        Console.WriteLine("Guess Higher");
                    }
                    else if (trial > magicNumber2)
                    {
                        Console.WriteLine("Guess Lower");
                    }
                    else
                    {
                        Console.WriteLine("You Guessed it!");
                        guessedCorrectly = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer as your guess.");
                }

            } while (!guessedCorrectly);
        }
    }
}