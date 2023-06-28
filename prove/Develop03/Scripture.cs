public class Scripture
{
    List<Word> scripture = new List<Word>();
    

    public List<Word> GetScripture(){
        return scripture;
    }


     public Scripture(string text)
     {
        string[] string1 = text.Split(" ");
        foreach(string word in string1){
            Word obj = new Word(word);
            scripture.Add(obj);
        }

     }

     public void DisplayScripture(){
        foreach(Word w in scripture){
            Console.Write($"{w.GetWord()} ");
        };
        }


     public void HideWords(List<Word> scriptureList){
        int wordsCounter = 0;
        while(wordsCounter < 3){
        if(IsCompletelyHidden(scriptureList) == true){
            break;
        }
        else{
        Random rnd = new Random();
        int index = rnd.Next(0,scriptureList.Count());
        if(scriptureList[index].GetIsHidden() == false){
            scriptureList[index].SetToHidden();
            scriptureList[index].SetWordUnderscore();
            wordsCounter ++;}
        }
        }
     }

     public bool IsCompletelyHidden(List<Word> scriptureList){
        bool flag = true;
        foreach(Word w in scriptureList){
            if(w.GetIsHidden() == false){
                flag = false;
                break;
            }
        }
        return flag;
     }
}