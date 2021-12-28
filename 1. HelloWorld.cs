/*
Filename: HelloWorld.cs

Created by: Joshua Culver
Last edited by: Joshua Culver

Creation date: 10/6/2020
Last edit date: 11/17/2020
*/

// Declares we are using "system" so we can use it's classes
using System;

//Class defines what a type of object is.
//Since C# is object oriented we need to do everything via objects
//For this program to be valid the "class" of the overall program must match the name of the file
class  HelloWorld{

    //Making this function public allows it to be invoked outside of this class
    public void hi(){
        // Console is a class of "system" and we call it's "write line" function passing it a sequence of characters
        Console.WriteLine("Hello World! \n");
    }
}