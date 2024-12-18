using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create running activity
        Activity running = new RunningActivity(new DateTime(2022, 11, 3), 30, 4.8);
        activities.Add(running);

        // Create cycling activity
        Activity cycling = new CyclingActivity(new DateTime(2022, 11, 4), 60, 15);
        activities.Add(cycling);

        // Create swimming activity
        Activity swimming = new SwimmingActivity(new DateTime(2022, 11, 5), 45, 10);
        activities.Add(swimming);

        // Display activities
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}