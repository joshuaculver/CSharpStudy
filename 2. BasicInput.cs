/*
Filename: BasicInput.cs

Created by: Joshua Culver
Last edited by: Joshua Culver

Creation date: 10/6/2020
Last edit date: 11/17/2020
*/

using System;

class BasicInput
{
    //Here we define properties of this class
    public string User
    //the following is the auto-implementation of the get and set accessors for the property
    //This is a handy feature of C#. In some other langauges getting and setting propeties has to be done by manually creating functions.
    {get; set;}
    
    //Declaring of main. As with other progamming languages it is what is run when this code is executed
    //Not shown here but Main can also take arguments
    public void binput()
    {
        // \n inserts a line break
        Console.WriteLine("Hello! What's your name?\n");
        //This line gets the input the user enters into the console
        string input = Console.ReadLine();
        //Below is the syntax for setting a class' property
        //You could combine the above and this line, but I haven't for clarity
        string User = input;

        //We can take all that and display our variable with some text with concatenation
        Console.WriteLine("Hello " + User + "!");
    }
}
