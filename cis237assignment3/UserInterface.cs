using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {
        public int ProcessDroidList()
        {
            this.PrintMenu();

            string userInput = Console.ReadLine();

            if (userInput != "1" && userInput != "2" && userInput != "3")
            {
                Console.WriteLine("Your choice was invalid.");
                this.ProcessDroidList();
            }

            return Convert.ToInt32(userInput);
        }

        public void AddDroid()
        {

            
        }

        private void PrintMenu()
        {
            Console.WriteLine("Please choose an option:" + Environment.NewLine +
                              "1 - Print the droid list." + Environment.NewLine +
                              "2 - Add a droid to the list." + Environment.NewLine + 
                              "3 - Exit the program.");
        }
    }
}
