/*
Filename: Menu.cs

Created by: Joshua Culver
Last edited by: Joshua Culver

Creation date: 10/6/2020
Last edit date: 12/29/2021
*/

using System;

class  Menu{
    //Creating some bool parameters to use later
    //A bool can either hold the "true" or "false" bool data.
    bool inMenu = true;
    bool keepGoing = false;

    //Making this function public allows it to be invoked outside of this class
    public void RunMenu(){
        //Pritning some information to the user
        Console.WriteLine("Hello! \n");
        Console.WriteLine("Here you can see the code of this project running. \n");

        //Input here is in a while loop so we can make sure we get something valid before we move on
        //The bool parameter is back and is set to true because we want to stay in the while loop until a condition is met
        //While means the loop will continue repeating until the "While" condition is no longer true
        while (inMenu == true){
            //"getSelection" will ensure that we get a valid integer to then use in "call" to figure out what to do.
            int input = getSelection();
            call(input);
        }//end in menu
        //This will execute once the "InMenu" loop ends
        Console.WriteLine("Goodbye!\n");
    }//end run menu
  
    

    //Function to check if a string can be converted to an integer
    public bool checkString(string entry){
        int check;
        //"try" and "catch" are exception handlers. They allow the program to continue if there is an error
        //Since we're going to attempt converting a string to an integer there are errors that could occur if the string is not valid
        try {
            //"int.parse()" takes the argument and attempts to convert it to an integer
            check = int.Parse(entry);
            return true;
            //Return ends the function.
        }
         //Giving "catch" an error will cause it to execute if that error occurs in "try"
        catch (FormatException){
            //Since there's no return or "keeGoing = false" if catch executes the loop continues
            Console.WriteLine("Invalid entry! \n");
            return false;
        }
    }

    //You can see instead of "void" for a function that returns nothing this function returns int
    //This function gets an integer to use later
    public int getSelection(){
        keepGoing = true;
        string entry = "N/A";

        while(keepGoing){
            Console.WriteLine("Please make a selection: ");
            Console.WriteLine(" 1. Hello World \n 2. Input \n 3. Classes \n 4. Race \n 5. Quit \n");

            entry = Console.ReadLine();

            if (checkString(entry)){
                keepGoing = false;
            }
        }// end while

        return int.Parse(entry);
    }//end getSelection()

    public void call(int input){
        //&& is "and" so the if requires both sides of && to evaluate true
        if(input >= 1 && input <= 5){
            if (input == 1){
                HelloWorld hello = new HelloWorld();
                hello.hi();
            }
            else if (input == 2){
                BasicInput inputEx = new BasicInput();
                inputEx.binput();
            }
            else if (input == 3){
                classEx classes = new classEx();
                classes.example();
            }
            else if(input == 4){
                Console.WriteLine("\n 1. Matched Race \n 2. Acceleration vs. Top speed \n");
                string pick = Console.ReadLine();

                if(checkString(pick)){
                    race race = new race();

                    race.selector(int.Parse(pick));
                }
            }
            else if (input == 5){
                inMenu = false;
            }
            //this "else" theoretically should not execute, but having it here can give this if/else tree an way to end if something goes wrong
            else{

            }
        }//end if
        else {
            Console.WriteLine("There isn't a " + input + " option! \n");
        }//end else
    }

}