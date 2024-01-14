// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         List<int> numbers = new List<int>();

//         Console.WriteLine("Enter your lucky numbers. Enter 0 to stop");

//         int userInput = -1;

//         while (userInput != 0)
//         {
//             Console.Write("Enter a number: ");
//             userInput = int.Parse(Console.ReadLine());

//             if (userInput != 0)
//             {
//                 numbers.Add(userInput);
//             }
//         }

//         if (numbers.Count > 0)
//         {
//             int sum = 0;
//             int max = int.MinValue;
//             int min = int.MaxValue;
//             int minPositive = int.MaxValue;

//             foreach (int number in numbers)
//             {
//                 sum += number;

//                 if (number > max)
//                 {
//                     max = number;
//                 }

//                 if (number < min)
//                 {
//                     min = number;
//                 }

//                 if (number > 0 && number < minPositive)
//                 {
//                     minPositive = number;
//                 }
//             }

//             double average = (double)sum / numbers.Count;

//             Console.WriteLine($"Sum: {sum}");
//             Console.WriteLine($"Average: {average:F2}");
//             Console.WriteLine($"Maximum: {max}");
//             Console.WriteLine($"Minimum: {min}");
//             Console.WriteLine($"MiniPositive: {minPositive}");
//         }
//         else
//         {
//             Console.WriteLine("No numbers entered.");
//         }
//     }
// }


using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int userNumber;

        do
        {
            Console.Write("Enter a number (0 to quit): ");
            string userResponse = Console.ReadLine();

            // Try to parse user input, if unsuccessful set userNumber to 0
            if (!int.TryParse(userResponse, out userNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                userNumber = 0; // Set to 0 to ensure loop continues
            }
            else if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        } while (userNumber != 0);

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Part 2: Compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the max
        int max = numbers.Count > 0 ? numbers[0] : 0;

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}