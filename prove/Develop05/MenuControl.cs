public class MenuControl{

    private int _menuOption = 0;
    private int _goalType = 0;
    
    
    public MenuControl()
    {}
    
    public int SelectMenuOption(){
        Console.Write("Menu Options \n1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit \nSelect a choice from the menu: ");
        _menuOption = int.Parse(Console.ReadLine());
        return _menuOption;
    }

    public int goalTypes(){
        Console.Write("The types of goals are: \n1. Simple Goals \n2. Eternal Goals \n3. Checklist Goals \nWhich type of goal would you like to create? ");
        _goalType = int.Parse(Console.ReadLine());
        return _goalType;
    }
}