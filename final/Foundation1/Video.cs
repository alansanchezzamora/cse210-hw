public class Video{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments = new List<Comment>();

    public void PrintList()
    {
        Console.WriteLine($"Video : {_title}. Author : {_author}. Length : {_length}s. Comments : {_comments.Count()}");
    }
}