using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("07/10/2023", 60, 10));
        activities.Add(new Swimming("07/12/2023", 20, 20));
        activities.Add(new Bicycle("07/09/2023", 50, 30));
        foreach(Activity act in activities){
            act.Summary();
        }

    }
}