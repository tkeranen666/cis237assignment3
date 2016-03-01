using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface UI = new UserInterface();

            int userInput = UI.ProcessDroidList();

            DroidCollection collection = new DroidCollection();
            collection.AddInitialDroids();

            while (userInput != 3)
            {
                if (userInput == 1) // If user selects 1, program prints list
                {
                    collection.PrintList();
                    Console.WriteLine();
                    Console.WriteLine();
                    userInput = UI.ProcessDroidList();
                }

                else if (userInput == 2) // If user selects 2, program adds a droid to the list (Not ready)
                {
                    collection.AddDroid();
                    Console.WriteLine();
                    Console.WriteLine();
                    userInput = UI.ProcessDroidList();
                }

                else if (userInput == 3) // If user selects 3, exit program
                {
                    Console.WriteLine("Logging off....");
                }
            }

        }
    }
}
