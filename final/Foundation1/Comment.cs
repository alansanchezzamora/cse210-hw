public class Comment{
    public string _name;
    public string _text;

    public void PrintComment()
    {
        Console.WriteLine($"Name: {_name} - Comment: {_text}");
    }

}