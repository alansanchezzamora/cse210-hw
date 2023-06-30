public class Activity{
    
    private int _activityTime;
    private string _activityDescription;
    private string _activityName;

    public Activity(string activityName, string activityDescription){

        _activityName = activityName;
        _activityDescription = activityDescription;

    }
    public int GetActivityTime()
    {
        return _activityTime;
    }


    public string DisplayWelcomeMessage(){
        return $"Welcome to the {_activityName}. \n{_activityDescription}.";
    }

    public int ActivityTime(){
        Console.Write("How Long in seconds, would you like for your session? ");
        _activityTime = int.Parse(Console.ReadLine());
        return _activityTime;
    }
    public string DisplayEndingMessage(){
        return $"You have compelted {_activityTime} seconds of the {_activityName}.";
    }

    public void SpinnerPause(){
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(3);

        int i = 0;
        while(DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(50);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count())
            {
                i = 0;
            }
        }
    }
}