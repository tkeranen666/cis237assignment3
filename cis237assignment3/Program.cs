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
            //string[] driodList = new string[100];
            //IDroid[] droidList = new Droid[100];

            UserInterface UI = new UserInterface();

            int userInput = UI.ProcessDroidList();

            DroidCollection DC = new DroidCollection();
            DC.AddInitialDroids();

            while (userInput != 3)
            {
                if (userInput == 1)
                {
                    DC.PrintList();
                    Console.WriteLine();
                    Console.WriteLine();
                    userInput = UI.ProcessDroidList();
                }

                else if (userInput == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    userInput = UI.ProcessDroidList();
                }

                else if (userInput == 3)
                {
                    Console.WriteLine("Logging off....");
                }
            }

        }
    }
}
