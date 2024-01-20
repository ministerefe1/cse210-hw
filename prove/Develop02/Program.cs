using System;
using System.Collections.Generic;
using System.IO;


// Program entry point (Main method)
class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Hello Develop02 World!");

        // Instantiate the Journal class
        Journal journal = new Journal();

        while (true)
        {
            // Display menu options to the user
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            // Read user input for menu choice
            string choice = Console.ReadLine();

            // Switch statement to handle user choices
            switch (choice)
            {
                case "1":
                    // Write a new entry to the journal
                    journal.WriteNewEntry();
                    break;

                case "2":
                    // Display all entries in the journal
                    Console.WriteLine("\nJournal Entries:");
                    journal.DisplayJournal();
                    break;

                case "3":
                    // Save the journal entries to a file
                    journal.SaveJournalToFile();
                    break;

                case "4":
                    // Load journal entries from a file
                    journal.LoadJournalFromFile();
                    break;

                case "5":
                    // Exit the program
                    Environment.Exit(0);
                    break;

                default:
                    // Invalid choice, ask the user to try again
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

// Class representing a single journal entry
class Entry
{
    private string prompt;
    private string response;
    private string date;

    // Constructor to initialize Entry with prompt, response, and date
    public Entry(string prompt, string response, string date)
    {
        this.prompt = prompt;
        this.response = response;
        this.date = date;
    }

    // Getter methods to access private fields
    public string GetPrompt()
    {
        return prompt;
    }

    public string GetResponse()
    {
        return response;
    }

    public string GetDate()
    {
        return date;
    }
}

// Journal class managing a collection of entries
class Journal
{
    private List<Entry> entries;

    // Constructor to initialize the journal with an empty list of entries
    public Journal()
    {
        entries = new List<Entry>();
    }

    // Method to write a new entry to the journal
    public void WriteNewEntry()
    {
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];

        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        entries.Add(new Entry(prompt, response, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
    }

    // Method to display all entries in the journal
    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.GetDate()}\nPrompt: {entry.GetPrompt()}\nResponse: {entry.GetResponse()}\n");
        }
    }

    // Method to save the journal entries to a file with a specified directory
    public void SaveJournalToFile()
    {
        // Prompt the user to enter the directory and file name
        Console.Write("Enter the directory to save the file (e.g., C:\\MyDirectory\\): ");
        string directory = Console.ReadLine();

        Console.Write("Enter the file name (e.g., MyJournal.txt): ");
        string fileName = Console.ReadLine();

        // Combine the directory and file name to create the full file path
        string fullPath = Path.Combine(directory, fileName);

        try
        {
            // Use StreamWriter to write entries to the specified file
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                foreach (var entry in entries)
                {
                    // Write each entry in the format: Date,Prompt,Response
                    writer.WriteLine($"{entry.GetDate()},{entry.GetPrompt()},{entry.GetResponse()}");
                }
            }

            // Display a message indicating that the entries have been successfully saved
            Console.WriteLine($"Journal entries saved to {fullPath} successfully.");
        }
        catch (Exception ex)
        {
            // Handle exceptions, such as invalid directory or file name
            Console.WriteLine($"Error saving journal entries: {ex.Message}");
        }
    }


    // Method to load journal entries from a file
    public void LoadJournalFromFile()
    {
        // Prompt the user to enter the file name
        Console.Write("Enter the file name to load: ");
        string fileName = Console.ReadLine();

        // Combine the current working directory and the user-specified file name
        string fullPath = Path.Combine(Environment.CurrentDirectory, fileName);

        // Clear existing entries before loading from the file
        entries.Clear();

        try
        {
            // Check if the file exists
            if (File.Exists(fullPath))
            {
                using (StreamReader reader = new StreamReader(fullPath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine().Split(',');
                        if (line.Length == 3)
                        {
                            // Create a new Entry and add it to the entries list
                            entries.Add(new Entry(line[1], line[2], line[0]));
                        }
                    }
                }

                // Display a message indicating that entries have been loaded successfully
                Console.WriteLine($"Journal entries loaded from {fullPath} successfully.");
            }
            else
            {
                // Display a message if the file does not exist
                Console.WriteLine($"Error: File {fullPath} not found.");
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions, such as invalid file format or access issues
            Console.WriteLine($"Error loading journal entries: {ex.Message}");
        }
    }

}




