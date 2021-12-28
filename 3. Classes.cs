/*
Filename: Classes.cs

Created by: Joshua Culver
Last edited by: Joshua Culver

Creation date: 10/6/2020
Last edit date: 11/17/2020
*/

using System;

//You can take a look at Person.cs to see an example of setting up a basic object
class classEx{

    //Classes don't need to have properties
    //Looking at Person.cs you can see how this object class was set up
    public void example(){
        //Initializing new Person objects with passed arguments for name and age
        Person human1 = new Person("Geoff", 32);
        Person human2 = new Person("Sarah", 29);

        //We can then pull those properties from the objects and use them
        //So we can concatenate something like this
        Console.WriteLine("Name: " + human1.Name + " Age: " + human1.Age + "\n");

        //C# has a garbage collector so there is no way to directly delete, or otherwise free the memory of, objects or data once created
        //Typically when an object or data isn't being used by the program anymore the garbage collector will free that memory.
        //We cannot in any way mark items to be collected or directly free them ourselves however.
    }

}