using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign (+, -, or none)
        string sign = "";
        int lastDigit = percent % 10;
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Special cases for A, F, and handle A+ and F+ or F-
        if (letter == "A")
        {
            if (percent == 100)
            {
                sign = "+";
            }
            else if (percent >= 97)
            {
                letter = "A+";
                sign = "";
            }
            else if (percent <= 93)
            {
                letter = "A-";
                sign = "";
            }
        }
        else if (letter == "F")
        {
            if (percent <= 57)
            {
                letter = "F";
                sign = "";
            }
            else
            {
                // Handle F+ or F-
                letter = "F";
            }
        }

        // Display both the grade letter and the sign
        Console.Write($"Your grade is {letter}{sign}");

        // Additional message based on passing or improvement
        if (percent >= 79)
        {
            Console.WriteLine(" - You passed");
        }
        else
        {
            Console.WriteLine(" - You need to improve on your grades");
        }
    }
}
