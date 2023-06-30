using System.IO;
using System.Collections.Generic;

class Journal
{
    static void Main(string[] args)
    {
        //This is where the user can see the menu and navigate
        int userChoice = 0;

        while (userChoice != 5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.Write("What would you like to do? ");

            //user input variable
            userChoice = Convert.ToInt32(Console.ReadLine());

            if (userChoice == 1) 
            {
                Entry.promptMethod();
            }

            else if (userChoice == 2)
            {
                //Display the file that was saved
                Entry.readMethod();
            }

            else if (userChoice == 3)
            {
                //User loads txt file that they created into the program
                Entry.loadMethod();
            }

            else if (userChoice == 4)
            {
                //User can save a txt file that they create
                Entry.saveMethod();
            }

            else if (userChoice == 5)
            {
                Console.WriteLine("Thank you for writing. See you next time!");
                break;
            }
        }


    }
}