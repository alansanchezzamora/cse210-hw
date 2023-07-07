using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int menuOption = 0;
        int goalType = 0;
        int totalScore = 0;
        List<Goal> _goals = new List<Goal>();
        MenuControl menu = new MenuControl();
        menuOption = menu.SelectMenuOption();

        while(menuOption != 6){
            if(menuOption == 1){
                Console.Clear();
                goalType = menu.goalTypes();
                if(goalType == 1){
                    SimpleGoal sgoal = new SimpleGoal();
                    sgoal.CreateGoal();
                    _goals.Add(sgoal);
                    Console.Clear();
                    menuOption = menu.SelectMenuOption();
                }
                else if(goalType == 2){
                    EternalGoal egoal = new EternalGoal();
                    egoal.CreateGoal();
                    _goals.Add(egoal);
                    menuOption = menu.SelectMenuOption();
                }
                else if(goalType == 3){
                    ChecklistGoal clgoal = new ChecklistGoal();
                    clgoal.CreateGoal();
                    _goals.Add(clgoal); 
                    menuOption = menu.SelectMenuOption();
                }
                Console.Clear();
            }
            if(menuOption == 2){
                int counter = 0;
                Console.Clear();
                Console.WriteLine($"Your score is {totalScore} points");
                foreach(Goal s in _goals){
                    counter ++;
                    Console.WriteLine($"{counter}. [{s.SetCompletedMark()}] {s.GetGoalName()} ({s.GetGoalDescription()}) {s.ReturnCompleted()} ");
                }
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();
                menuOption = menu.SelectMenuOption();
            }
            if(menuOption == 3){
                Console.Clear();
                Console.Write("Save to file: ");
                string filename = Console.ReadLine();
                using(StreamWriter OutputFile = new StreamWriter(filename))
                {
                    int counter = 0;
                    OutputFile.WriteLine(totalScore);
                    foreach(Goal s in _goals){
                    counter++;
                    OutputFile.WriteLine($"{s.GetGoalTypeName()}±{counter}±{s.GetGoalName()}±{s.GetGoalDescription()}±{s.GetGoalPoints()}±{s.PrintToFile()}");
                    }                
                }
                menuOption = menu.SelectMenuOption();
            }
            if(menuOption ==4){
                Console.Clear();
                Console.Write("Open file: ");
                string fileName = Console.ReadLine();
                string [] userFile = System.IO.File.ReadAllLines(fileName);
                totalScore = int.Parse(File.ReadLines(fileName).FirstOrDefault());
                foreach(string line in userFile){
                    string [] parts = line.Split("±");
                    if(parts[0]=="SimpleGoal"){
                        SimpleGoal sgoal = new SimpleGoal();
                        sgoal.SetGoalID(int.Parse(parts[1]));
                        sgoal.SetGoalName(parts[2]);
                        sgoal.SetGoalDescription(parts[3]);
                        sgoal.SetGoalPoints(int.Parse(parts[4]));
                        sgoal.SetGoalType(1);
                        sgoal.SetGoalTypeName(parts[0]);
                        if(parts[5] == "True"){
                            sgoal.SetIsCompelte();
                        }
                        _goals.Add(sgoal);
                    }
                    if(parts[0]=="EternalGoal"){
                        EternalGoal egoal = new EternalGoal();
                        egoal.SetGoalID(int.Parse(parts[1]));
                        egoal.SetGoalName(parts[2]);
                        egoal.SetGoalDescription(parts[3]);
                        egoal.SetGoalPoints(int.Parse(parts[4]));
                        egoal.SetGoalType(2);
                        egoal.SetGoalTypeName(parts[0]);
                        _goals.Add(egoal);
                    }
                    if(parts[0]=="ChecklistGoal"){
                        ChecklistGoal chgoal = new ChecklistGoal();
                        chgoal.SetGoalID(int.Parse(parts[1]));
                        chgoal.SetGoalName(parts[2]);
                        chgoal.SetGoalDescription(parts[3]);
                        chgoal.SetGoalPoints(int.Parse(parts[4]));
                        chgoal.SetGoalType(3);
                        chgoal.SetGoalTypeName(parts[0]);
                        chgoal.SetBonusPoints(int.Parse(parts[5]));
                        chgoal.SetTimesToComplete(int.Parse(parts[6]));
                        chgoal.SetTimesCompelted(int.Parse(parts[7]));
                        _goals.Add(chgoal);
                    }

                }
                Console.Clear();
                Console.WriteLine($"You have {totalScore} points");
                menuOption = menu.SelectMenuOption();
            }
            if(menuOption == 5){
                Console.Clear();
                int counter = 0;
                foreach(Goal s in _goals){
                    counter ++;
                    Console.WriteLine($"{counter}. {s.GetGoalName()}");
                }
                Console.WriteLine("Which goal did you accomplish?");
                int goalAccomplished = int.Parse(Console.ReadLine()) - 1;
                int awardedPoints = (_goals[goalAccomplished].GetGoalPoints());
                _goals[goalAccomplished].GoalCompleted();
                totalScore = totalScore + _goals[goalAccomplished].GetGoalPoints() + _goals[goalAccomplished].GetBonusPoints();
                Console.WriteLine($"Your total score is {totalScore}");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();
                menuOption = menu.SelectMenuOption();
            }
        }   
    }
}