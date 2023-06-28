public class Word
{
    
    private bool _hidden;
    private string _word;

    public Word(string text){
        _word = text;
        _hidden = false;
    }

    public string GetWord(){
        return _word;
    }
    
    public void SetWordUnderscore(){
        _word = new string('_',_word.Length);
    }   

    public bool GetIsHidden(){
        return _hidden;
    }

    public void SetToHidden(){
        _hidden = true;
    }
}