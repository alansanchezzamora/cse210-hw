public class Resume
{
    public string _name;    
    public List<Job> _jobs = new List<Job>();

    public void DisplayJobDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job c in _jobs)
        {
            c.DisplayJobDetails();
        }
    }
}