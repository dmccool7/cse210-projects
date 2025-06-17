using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run = new Running("17 June 2025", 30, 3);
        activities.Add(run);

        Swimming swim = new Swimming("16 June 2025", 45, 30);
        activities.Add(swim);

        Cycling cycle = new Cycling("15 June 2025", 25, 20);
        activities.Add(cycle);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}