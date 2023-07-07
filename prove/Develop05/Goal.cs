public abstract class Goal{
    protected int _goalID;
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;    
    protected int _goalType;
    protected string _goalTypeName;
    protected int  _completeCount;
    public Goal(int goalID, string goalName, string goalDescription, int goalPoints, int goalType, string goalTypeName){
        _goalID = goalID;
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _goalType = goalType;
        _goalTypeName = goalTypeName;
    }
    public Goal()
    {}
    public int GetGoalID(){
        return _goalID;
    }
    public void SetGoalID(int goalID){
        _goalID = goalID;
    }
    public string GetGoalTypeName(){
        return _goalTypeName;
    }
    public void SetGoalTypeName(string goalTypeName){
        _goalTypeName = goalTypeName;        
    }
    public string GetGoalName(){
        return _goalName;
    }
    public void SetGoalName(string goal){
        _goalName = goal;        
    }

    public string GetGoalDescription(){
        return _goalDescription;
    }
    public void SetGoalDescription(string description){
        _goalDescription = description;        
    }
    public int GetGoalPoints(){
        return _goalPoints;
    }
    public void SetGoalPoints(int points){
        _goalPoints = points;        
    }


    public int GetGoalType(){
        return _goalType;
    }
    public void SetGoalType(int GoalType){
        _goalType = GoalType;
    }
    public abstract void CreateGoal();

    public abstract string ReturnCompleted();

    public abstract string PrintToFile();

    public abstract void GoalCompleted();

    public abstract string SetCompletedMark();
    
    public abstract int GetBonusPoints();
    

}