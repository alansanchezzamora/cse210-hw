public class Reference
{
    private string _book;
    private int _chapter;
    private int _start;
    private int _end;

    public Reference(string reference){
        string[] separate = {":", "-"};
        string[] splitReference = reference.Split(separate, StringSplitOptions.None);
        string[] splitChapter = splitReference[0].Split(" ");

        if(splitChapter.Count() > 2){
            string[] book = splitChapter.SkipLast(1).ToArray();
            _book = string.Join(" ", book);
            _chapter = int.Parse(splitChapter[splitChapter.Count()-1]);

        }else{
            _book = splitChapter[0];
            _chapter = int.Parse(splitChapter[1]);
        }
        if(splitReference.Count() == 3){
            _start = int.Parse(splitReference[1]);
            _end = int.Parse(splitReference[2]);
        } else if(splitReference.Count() ==2){
            _start = int.Parse(splitReference[1]);
        }
    }
    public void ShowReference(){
        if(_end == 0){  
            Console.WriteLine(_book + " " + _chapter + ":" + _start);
        } else{
            Console.WriteLine(_book +" "+_chapter + ":" + _start +"-"+ _end);
        }
    }
}