public class EternalGoal : Goal{
    public EternalGoal(int goalID, string goalName, string goalDescription, int goalPoints, int goalType, string goalTypeName)
    :base(goalID, goalName, goalDescription, goalPoints, goalType, goalTypeName){
    }
    public EternalGoal()
    {}
    public override void CreateGoal()
    {
        Console.WriteLine("What's the name of the goal?");
        string GoalName = Console.ReadLine();
        SetGoalName(GoalName);
        Console.WriteLine("What is a short description of it?");
        string goalDescription = Console.ReadLine();
        SetGoalDescription(goalDescription);
        Console.WriteLine("What is the ammount of points associated to this goal?");
        int GoalPoints = int.Parse(Console.ReadLine());
        SetGoalPoints(GoalPoints);
        SetGoalType(2);
        SetGoalTypeName("EternalGoal");
    }
        public override string ReturnCompleted()
    {
        return "";
    }
    public override string PrintToFile()
    {
        return "";
    }
    public override void GoalCompleted()
    {
    }
}