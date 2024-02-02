using System;

public class Assignment
{
    // Member variables
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to get the student's name and topic
    public string GetSummary()
    {
        return $"Student Name: {_studentName}, Topic: {_topic}";
    }
}

// MathAssignment.cs

public class MathAssignment : Assignment
{
    // Additional private member variable for MathAssignment
    private int _problemsSolved;

    // Constructor calling the base class constructor
    public MathAssignment(string studentName, string topic, int problemsSolved)
        : base(studentName, topic)
    {
        _problemsSolved = problemsSolved;
    }

    // Override GetSummary method to include additional information
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - {_problemsSolved} problems solved";
    }

    // New method for MathAssignment
    public string GetHomeworkList()
    {
        // Replace with your logic for homework list
        return "Homework List: Complete Exercise 1, Read Chapter 2, Solve Practice Problems";
    }
}
// Program.cs

class Program
{
    static void Main(string[] args)
    {
        // Test base Assignment class
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        string assignmentSummary = assignment.GetSummary();
        Console.WriteLine(assignmentSummary);

        // Test MathAssignment class
        MathAssignment mathAssignment = new MathAssignment("John Doe", "Algebra", 15);
        string mathAssignmentSummary = mathAssignment.GetSummary();
        Console.WriteLine(mathAssignmentSummary);

        string homeworkList = mathAssignment.GetHomeworkList();
        Console.WriteLine(homeworkList);
    }
}
