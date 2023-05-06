public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayJobDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job a in _jobs)
        {
            a.DisplayJobDetails();
        }
    }
}