using System;
using System.Collections.Generic;

public class Resume
{
    public string Name { get; set; }
    public List<Job> Jobs { get; } = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Resume of {Name}\n");

        foreach (var job in Jobs)
        {
            job.Display();
            Console.WriteLine();
        }
    }
}
