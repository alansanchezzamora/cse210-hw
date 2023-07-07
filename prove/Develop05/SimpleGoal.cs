public class SimpleGoal : Goal{

    private bool _isComplete;
    public SimpleGoal(int goalID, string goalName, string goalDescription, int goalPoints, int goalType, string goalTypeName)
    :base(goalID, goalName, goalDescription, goalPoints, goalType, goalTypeName){
    }

    public SimpleGoal()
    {}
    public bool GetIsComplete(){
        return _isComplete;
    }
    public void SetIsCompelte(){
        _isComplete = true;
    }
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
        SetGoalType(1);
        SetGoalTypeName("SimpleGoal");
    }

    public override string ReturnCompleted()
    {
        return "";
    }

    public override string PrintToFile()
    {
        return $"{GetIsComplete()}";
    }

    public override void GoalCompleted()
    {
        SetIsCompelte();
        Console.WriteLine($"Congratulations you earned {GetGoalPoints()} points.");
    }
    public override string SetCompletedMark()
    {
        if(GetIsComplete() == true){
            return "X";
        }
        else{
            return "";
        }
    }

    public override int GetBonusPoints()
    {
        return 0;
    }

}