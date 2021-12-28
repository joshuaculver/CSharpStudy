/*
Filename: Main.cs

Created by: Joshua Culver
Last edited by: Joshua Culver

Creation date: 10/6/2020
Last edit date: 12/28/2020
*/

//Namespace tells the compiler where to look for files for this project
//Unlike in something like C or C++ where you manually declare and include headers
namespace CSharpProject {
    class landing{
        //Declaring of main. As with other progamming languages it is what is run when this code is executed
        //For this C# project there can only be one main
        //Not shown here but Main can also take arguments
        static void Main(string[] args){
            //Here a menu object is being created an one of it's functions being called.
            Menu menu = new Menu();
            menu.RunMenu();
        }
    }
}