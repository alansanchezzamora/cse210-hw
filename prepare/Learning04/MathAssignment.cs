public class MathAssignment : Assignment{
    private string _textbook;
    private string _problems;


    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
    : base(studentName, topic){
        _textbook = textbookSection;
        _problems = problems;
}
    public string GetHomeworkList(){
        return $"Book:{_textbook} Problems: {_problems}";
    }

}
    