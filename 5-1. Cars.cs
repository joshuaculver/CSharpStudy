/*
Filename: Cars.cs

Created by: Joshua Culver
Last edited by: Joshua Culver

Creation date: 10/6/2020
Last edit date: 11/17/2020
*/

using System;

//In C# you can have multiple classes per file
//In some other langauges each class has to have it's own header file and then their own defintion file
class track{
    car car1;
    car car2;

    int length;

    //Default instantiator
    public track(){
        car1 = new racing();
        car2 = new racing();

        length = 50;
    }

    //Varying set-ups for tracks to be made with different information
    public track(int num){
        car1 = new racing();
        car2 = new racing();

        length = num;
    }

    public track(car vehicle1, car vehicle2){
        car1 = vehicle1;
        car2 = vehicle2;
        
        length = 50;
    }

    public track(int num, car vehicle1, car vehicle2){
        car1 = vehicle1;
        car2 = vehicle2;
        
        length = num;
    }

    //Has each car advance in the race
    public void step(){
        car1.go();
        //Make's sure the car doesn't shoot off the track
        if(car1.pos > length){
            car1.pos = length;
        }

        car2.go();
        if(car2.pos > length){
            car2.pos = length;
        }
    }

    //Shows position of each car
    public void showRace(){
        showPos(car1);
        showPos(car2);
    }

    //Prints an "." for each segment of length in the track and a "o" where the car currently is
    public void showPos(car car){
        //Empty line for readability
        Console.Write("\n");

        //Loops for every unit of length in the race
        for(int i = 0; i <= length; i++){
            if(car.pos == i){
                Console.Write("o");
            }
            else{
                Console.Write(".");
            }
        }
        Console.Write("\n");
    }

    //Checks both cars to see if either or both have won.
    public bool checkWin(){
        if (car1.pos >= length && car2.pos >= length){
            Console.WriteLine("It's a tie! \n");
            return false;
        }
        else if(car1.pos >= length){
            Console.WriteLine("The top car in position 1 wins! \n");
            return false;
        }
        else if(car2.pos >= length){
            Console.WriteLine("The bottom car in position 2 wins! \n");
            return false;
        }
        else{
            return true;
        }
    }

    //Performs a race with the current track and cars.
    public void competition(){
        bool racing = true;

        showRace();

        Console.WriteLine("And they're off! \n");
        while(racing){
            step();
            showRace();

            //Has the user advance the race by pressing a key before the next step
            Console.WriteLine("\n Press any key to continue...");
            Console.ReadKey();
            Console.Write("\n");

            racing = checkWin();
        }
    }
}

//Abstract classes cannot be instantiated
//In this context this abstract car is being used to inform the "base" of classes inhereting from it
//If we define this abstract class has something a child class of this class must have it to be instantiated
abstract class car{
    public int topSpd;
    public int accel;
    public int currSpd = 0;
    public int pos = 0;

    //random number generation object
    public Random rnd = new Random();

    //Abstract methods. Nothing is declared for them but classes inhereting car have to have them.
    public abstract void go();

    //car increases speed based on acceleration
    public abstract int getSpeed();
}

//This car is a sub-type of car that can be instantiated
class racing: car{

    public racing(){
        topSpd = 20;
        accel = 3;
    }

    public racing(int spd, int acc){
        topSpd = spd;
        accel = acc;
    }

    //This is how the car advances along the track. By increasing it's position using it's speed.
    override public void go(){
        currSpd = getSpeed();
        pos += currSpd;
    }

    override public int getSpeed(){
        //If the car is already at top speed we don't need to get a new speed
        if(currSpd == topSpd){
            return 0;
        }

        //Speed increase is a little random for fun
        int increase = accel += rnd.Next(0,3);
        currSpd += increase;

        //Car cannot go above it's maximum speed.
        if(currSpd >= topSpd){
            currSpd = topSpd;
        }
        return currSpd;
    }
}