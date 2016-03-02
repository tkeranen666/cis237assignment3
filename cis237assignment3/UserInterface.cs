using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tim Keranen

namespace cis237assignment3
{
    class UserInterface // The UserInterface class handles user input and passes it to other classes.
    {
        private string userInput; // This string holds the majority of the input given by the user.

        public int ProcessDroidList()
        {
            this.PrintMenu();

            userInput = Console.ReadLine();

            if (userInput != "1" && userInput != "2" && userInput != "3")
            {
                Console.WriteLine("Your choice was invalid.");
                this.ProcessDroidList();
            }
            return Convert.ToInt32(userInput);
        }

        public string AddDroid()    
        {                      
            Console.WriteLine();
            Console.WriteLine("What is the droid's fuction?" + Environment.NewLine +
                              "1 - Protocal" + Environment.NewLine +
                              "2 - Astromech" + Environment.NewLine +
                              "3 - Janitor");

            userInput = Console.ReadLine();

            if (userInput != "1" && userInput != "2" && userInput != "3")
            {
                Console.WriteLine("Your choice was invalid.");
                this.AddDroid();
            }
            if (userInput == "1")
            {
                return "Protocal";
            }
            else if (userInput == "2")
            {
                return "Astromech";
            }
            else if (userInput == "3")
            {
                return "Janitor";
            }
            return "";
        }

        public string AddMaterial()
        {
            Console.WriteLine();
            Console.WriteLine("What material is the droid made of?" + Environment.NewLine +
                              "1 - Carbon-steel Alloy" + Environment.NewLine +
                              "2 - Plasteel" + Environment.NewLine +
                              "3 - Aluminum-steel Alloy" + Environment.NewLine +
                              "4 - Other");

            userInput = Console.ReadLine();

            if (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4")
            {
                Console.WriteLine("Your choice was invalid.");
                this.AddMaterial();
            }
            else if (userInput == "1")
            {
                return "Carbon-steel Alloy";
            }
            else if (userInput == "2")
            {
                return "Plasteel";
            }
            else if (userInput == "3")
            {
                return "Aluminum-steel Alloy";
            }
            else if (userInput == "4")
            {
                Console.WriteLine();
                Console.WriteLine("What is the material?");
                return Console.ReadLine();
            }
            return "";
        }

        public string AddModel()
        {
            Console.WriteLine();
            Console.WriteLine("What is the droid's model?");
            return Console.ReadLine();
        }

        public string AddColor()
        {
            Console.WriteLine();
            Console.WriteLine("What is the droid's color?");
            return Console.ReadLine();
        }

        public int AddLanguages()
        {
            Console.WriteLine();
            Console.WriteLine("How many languages does the droid speak?");
            userInput = Console.ReadLine();

            try
            {
                Convert.ToInt32(userInput);
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Your choice was invalid.");
                AddLanguages();
            }
            return Convert.ToInt32(userInput);
        }

        public bool AddOptions()
        {
            Console.WriteLine("1 - Yes" + Environment.NewLine + "2 - No");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                return true;
            }
            else if (userInput == "2")
            {
                return false;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Your choice was invalid.");
                this.AddOptions();
            }
            return false;
        }

        public int AddShips()
        {
            Console.WriteLine();
            Console.WriteLine("How many ships can your droid pilot?");
            userInput = Console.ReadLine();

            try
            {
                Convert.ToInt32(userInput);
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Your choice was invalid.");
                AddShips();
            }

            return Convert.ToInt32(userInput);
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
