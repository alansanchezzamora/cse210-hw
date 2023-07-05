public class ChecklistGoal : Goal{
    private int _timesToComplete;
    private int _bounsPoints;
    private int _timesCompleted;


    public ChecklistGoal(int goalID, string goalName, string goalDescription, int goalPoints, int goalType, string goalTypeName, int timesCompleted, int timesToComplete, int bonusPoints, int completeCount)
    :base(goalID, goalName, goalDescription, goalPoints, goalType, goalTypeName){
        _timesToComplete = timesToComplete;
        _bounsPoints = bonusPoints;
        _timesCompleted = timesCompleted;
        _completeCount = completeCount;
    }
    public ChecklistGoal()
    {}
    public int GetTimesCompleted(){
        return _timesCompleted;
    }
    public void SetTimesCompelted(int timesCompleted){
        _timesCompleted = timesCompleted ;
    }
    public int GetTimesToComplete(){
        return _timesToComplete;
    }

    public void SetTimesToComplete(int timesToComlete1){
        _timesToComplete = timesToComlete1;
    }

    public int GetBonusPoints(){
        return _bounsPoints;
    }
    public void SetBonusPoints( int bonusPoints1){
        _bounsPoints = bonusPoints1;
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
        Console.WriteLine("How many times does this goal needs to be accomplished for a bonus?");
        int timesForBonus = int.Parse(Console.ReadLine());
        SetTimesToComplete(timesForBonus);
        Console.WriteLine("What is the bonus for accomplishing it that many times?");
        int bPoints = int.Parse(Console.ReadLine());
        SetBonusPoints(bPoints);
        SetGoalType(3);
        SetGoalTypeName("ChecklistGoal");
    }
        public override string ReturnCompleted()
    {
     return $"-- Currently Completed: {GetTimesCompleted()} / {GetTimesToComplete()}";   
    }

    public override string PrintToFile()
    {
        return $"{GetBonusPoints()}±{GetTimesToComplete()}±{GetTimesCompleted()}";
    }

    public override void GoalCompleted()
    {
        if(GetTimesCompleted() < GetTimesToComplete()){
            _timesCompleted++;
            SetTimesCompelted(_timesCompleted);
            Console.WriteLine($"Congratulations you earned {GetGoalPoints()} points.");
            if(_timesCompleted == _timesToComplete ){
                Console.WriteLine($"Congratulations! You completed the goal. You win {GetBonusPoints()}");
            }
        }
    }

}