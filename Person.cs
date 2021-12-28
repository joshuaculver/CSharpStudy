/*
Filename: Person.cs

Created by: Joshua Culver
Last edited by: Joshua Culver

Creation date: 10/6/2020
Last edit date: 11/17/2020
*/

using System;
class Person{
    //Private means this property can only be accsessed and/or changed by this class
    private string name;
    //Since our properties are private we can use get and set with public data to accsess them
    //If we were to leave out get or set we could make our properties read or write only respectively
    public string Name{
        get {return name;}
        //value in this case will accept an assigned value if appropriate
        set {name = value;}
    }

    private int age;
    public int Age{
        get {return age;}
        set {age = value;}
    }

    //Bool is a true or false value
    private bool alive;
    public bool Alive{
        get {return alive;}
        set {alive = value;}
    }



    //This is a constructor for this class.
    //This one will decide how a person gets initialized if it isn't passed any arguments
    public Person(){
        //Default values since none have been given.
        name = "none";
        age = 0;

        //We're abitrarily going to create a Person alive.
        alive = true;
    }

    //This one can be given a string to both create a new person object and name it.
    public Person(string str){
        name = str;
        age = 0;
        alive = true;
    }

    public Person(string str, int num){
        name = str;
        age = num;
        alive = true;
    }
}