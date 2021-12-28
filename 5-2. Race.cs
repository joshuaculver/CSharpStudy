/*
Filename: Race.cs

Created by: Joshua Culver
Last edited by: Joshua Culver

Creation date: 10/6/2020
Last edit date: 11/17/2020
*/

using System;
class race{
    track stadium;

    //Takes a number to select a function
    public void selector(int i){
        if(i == 1){
            quickRace();
        }
        else if(i == 2){
            customRace();
        }
        else{
            Console.WriteLine(i + " isn't an option! \n");
        }
    }

    //Does a race with the default settings
    public void quickRace(){
        stadium = new track();

        stadium.competition();
    }

    //An example of a race with different styles of cars
    public void customRace(){
        car car1 = new racing(15, 5);
        car car2 = new racing(30, 2);

        stadium = new track(65, car1, car2);
        stadium.competition();
    }
}