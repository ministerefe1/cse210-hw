using System;
using System.Collections.Generic;

class Activity
{
    protected string date;
    protected int lengthInMinutes;

    public Activity(string date, int lengthInMinutes)
    {
        this.date = date;
        this.lengthInMinutes = lengthInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{date} {GetType().Name} ({lengthInMinutes} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}

class Running : Activity
{
    private double distance; // in miles

    public Running(string date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (lengthInMinutes / 60);
    }

    public override double GetPace()
    {
        return lengthInMinutes / distance;
    }
}

class StationaryBicycle : Activity
{
    private double speed; // in mph

    public StationaryBicycle(string date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return speed * (lengthInMinutes / 60);
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }
}

class Swimming : Activity
{
    private int laps;

    public Swimming(string date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000 * 0.62; // in miles
    }

    public override double GetSpeed()
    {
        return (laps * 50 / 1000) / (lengthInMinutes / 60);
    }

    public override double GetPace()
    {
        return 60 / ((laps * 50 / 1000) / (lengthInMinutes / 60));
    }
}

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        // Create activities
        Running runningActivity = new Running("03 Nov 2022", 30, 3.0);
        StationaryBicycle bicycleActivity = new StationaryBicycle("04 Nov 2022", 45, 15.0);
        Swimming swimmingActivity = new Swimming("05 Nov 2022", 60, 20);

        // Add activities to the list
        activities.Add(runningActivity);
        activities.Add(bicycleActivity);
        activities.Add(swimmingActivity);

        // Display summaries for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
