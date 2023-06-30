using System;

class Program
{
    static void Main(string[] args)
    {
        
        string option = "";
        int counterActs = 0;
        int counterTime = 0;
        
        MenuControl menu1 = new MenuControl();
        Activity act1 = new Activity("menu", "none");

        option = menu1.SelectMenuOption();
        int time = 0;

        while (option != "4"){
            if(option == "1"){
                Console.Clear();
                BreathingActivity bact = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Console.WriteLine(bact.DisplayWelcomeMessage());
                time = bact.ActivityTime();
                bact.activity();
                bact.SpinnerPause();
                Console.WriteLine(bact.DisplayEndingMessage());
                Thread.Sleep(3000);
                Console.Clear();
                counterActs ++;
                counterTime += time;
                option = menu1.SelectMenuOption();
            }
            
            else if(option == "2"){
                Console.Clear();
                ReflectionActivity ract = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Console.WriteLine(ract.DisplayWelcomeMessage());
                time = ract.ActivityTime();
                ract.Prompt();
                ract.Questions();
                ract.SpinnerPause();
                Console.WriteLine(ract.DisplayEndingMessage());
                Thread.Sleep(3000);
                Console.Clear();
                counterActs ++;
                counterTime += time;
                option = menu1.SelectMenuOption();
            }
            
            else if(option =="3"){
                Console.Clear();
                ListingActivity lact = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Console.WriteLine(lact.DisplayWelcomeMessage());
                time = lact.ActivityTime();
                lact.Prompt();
                lact.EntriesList();
                lact.SpinnerPause();
                Console.WriteLine(lact.DisplayEndingMessage());
                Thread.Sleep(3000);
                Console.Clear();
                counterActs ++;
                counterTime += time;
                option = menu1.SelectMenuOption();
            }
            else{
                Console.Clear();
                Console.WriteLine("Enter a valid option");
                option = menu1.SelectMenuOption();
            
            }
        
            
        }
    Console.WriteLine($"In this session you completed {counterActs} activities in {counterTime} seconds.");
    act1.SpinnerPause();
    }
}