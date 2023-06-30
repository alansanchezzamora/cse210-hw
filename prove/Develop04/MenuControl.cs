public class MenuControl{

    private string _menuOption = "";
    
    public MenuControl(){

    }
    
    public string SelectMenuOption(){
        Console.Write("Menu Options \n1. Start breathing activiy \n2. Start reflecting activity \n3. Start listing activity \n4. Quit \nSelect a choice from the menu: ");
        _menuOption = Console.ReadLine();
        return _menuOption;
    }

}