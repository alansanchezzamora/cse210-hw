public class ReflectionActivity : Activity{

    private List<string> prompts = new List<string>();
    private List<string> questions = new List<string>();


    public ReflectionActivity(string activityName, string activityDescription)
    : base(activityName, activityDescription){

    }
    public void Prompt(){
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");

        var random = new Random();
        var index = random.Next(0, prompts.Count);
        string output = $"Consider the following prompt: \n ---{prompts[index]}--- \n When you have something in mind, press enter to continue.";
        Console.WriteLine(output);
        Console.ReadLine();
    }

    public void Questions(){
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");
        

        int activityTime = GetActivityTime();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(activityTime);
        while(DateTime.Now < endTime)
        {
        var random = new Random();
        var index = random.Next(0, questions.Count);
        Console.WriteLine($"{questions[index]} ");
        Thread.Sleep(5000);
        }
        Console.WriteLine("Activity Completed");
        }
}
    //Show generic finish message 
