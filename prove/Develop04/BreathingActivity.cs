public class BreathingActivity : Activity{


    public BreathingActivity(string activityName, string activityDescription)
    : base( activityName, activityDescription){

    }
    public void activity(){

    int activityTime = GetActivityTime();
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(activityTime);

    while(DateTime.Now < endTime)
    {
        Console.WriteLine("Breathe In: ");
        for(int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
        
        Console.WriteLine("Hold...");
        for(int i = 7; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
        Console.WriteLine("Breathe out: ");
        for(int i = 8; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}


    //Welcome to the breathing activity
    //description: "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."

    //How long in seconds, would you like for your session?
    //Breathe in Message.
    //Timer for some seconds
    //Clear console
    //Breathe out Message
    //Timer for some seconds
    //Clear Console

    //well done!! 
    //spinner 4 seconds
    //You have completed antother {time} of the {activity} activity.
    //4 seconds
    //go to menu
}