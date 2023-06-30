public class ListingActivity : Activity{
    private List<string> entries = new List<string>();
    private List<string> prompts = new List<string>();

    public ListingActivity(string activityName, string activityDescription)
    : base(activityName, activityDescription ){

    }
    public void Prompt(){
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");
        prompts.Add("What are personal strengths of yours?");
        var random = new Random();
        var index = random.Next(0, prompts.Count);
        Console.WriteLine($"Consider the following prompt: \n ---{prompts[index]}---");
        Console.Write("You may begin in: ");
        for(int i = 9; i>0; i--)
        {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        }
    }

    public void EntriesList(){
        
        int activityTime = GetActivityTime();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(activityTime);
        while(DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            entries.Add(item);
        }
        Console.WriteLine($"You listed {entries.Count()} items!");
    }

}