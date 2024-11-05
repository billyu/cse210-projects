// Class: Resume
// Responsibilities:
//      Keeps track of the person's name and a list of their jobs.
// Behaviors:
//      Displays the resume, which shows the name first, followed by displaying each one of the jobs.

using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Resume of {_name}");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}