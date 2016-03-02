using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tim Keranen
// CIS 237
// Assignment 3

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = 5000; // Extends the length of the console.

            UserInterface UI = new UserInterface(); // Create a new instance of the UserInterface class to handle user input.

            DroidCollection collection = new DroidCollection(); // Create new instance of Droid Collection class to create array.

            collection.AddInitialDroids(); // Call DroidCollection class to fill first six items in array so the program has something to print.

            int userInput = UI.ProcessDroidList(); // Call UserInterface class to process and pass user input the main program.

            while (userInput != 3)
            {
                if (userInput == 1) // If user selects 1, the program calls DroidCollection's PrintList() method.
                {
                    collection.PrintList();
                    Console.WriteLine();
                    Console.WriteLine();
                    userInput = UI.ProcessDroidList(); // After printing, the program returns to the menu in UserInterface.
                }

                if (userInput == 2) // If user selects 2, the program calls DroidCollection's AddDroid method.
                {
                    collection.AddDroid();
                    Console.WriteLine();
                    Console.WriteLine();
                    userInput = UI.ProcessDroidList();
                }

                if (userInput == 3) // If user selects 3, the program closes.
                {
                    Console.WriteLine("Logging off....");
                }
            }

        }
    }
}
