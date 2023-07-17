public class Video{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments = new List<Comment>();

    public string PrintList()
    {
        return $"Video : {_title}. Author : {_author}. Length : {_length}s.";
    }

    public string CommentsNumber()
    {
        return $"Comments : {_comments.Count()}";

    }

    public void PrintComments()
    {
        foreach (Comment C in _comments)
        {
            C.PrintComment();
        }

    }
}