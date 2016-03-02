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

        public int ProcessDroidList() // This method calls the PrintMenu() method and handles input prompted. 
        {
            this.PrintMenu();

            userInput = Console.ReadLine();

            if (userInput != "1" && userInput != "2" && userInput != "3")
            {
                // If the input is not 1, 2, or 3, ProcessDroidList() is called again to aquire new input.
                Console.WriteLine("Your choice was invalid.");
                this.ProcessDroidList();
            }
            return Convert.ToInt32(userInput); // The user generated input is converted to an integer value
        }                                     // and then passed on to Main.

        public string AddDroid() // This method allows the user choose which type of droid they want to add.   
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
            if (userInput == "1") // If the user selects 1, the droid is a Protocal.
            {
                return "Protocal";
            }
            else if (userInput == "2") // If the user selects 2, the droid is an Astromech.
            {
                return "Astromech";
            }
            else if (userInput == "3") // If the user selects 3, the droid is a Janitor.
            {
                return "Janitor";
            }
            return ""; // This return value is required for the method to run, but it is never reached.
        }

        public string AddMaterial() // This method allows the user choose which type of material 
        {                          // they want their droid to be made of.
            Console.WriteLine();
            Console.WriteLine("What material is the droid made of?" + Environment.NewLine +
                              "1 - Thermasteel" + Environment.NewLine +
                              "2 - Plasteel" + Environment.NewLine +
                              "3 - Plastoid Alloy" + Environment.NewLine +
                              "4 - Other");

            userInput = Console.ReadLine();

            if (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4")
            {
                Console.WriteLine("Your choice was invalid.");
                this.AddMaterial();
            }
            else if (userInput == "1") // If user select 1, 2, or 3, they choose one of the pre-listed
            {                         //  materials for the droid.
                return "Thermasteel";
            }
            else if (userInput == "2")
            {
                return "Plasteel";
            }
            else if (userInput == "3")
            {
                return "Plastoid Alloy";
            }
            else if (userInput == "4") // If the user selects 4, they enter their own material.
            {
                Console.WriteLine();
                Console.WriteLine("What is the material?");
                return Console.ReadLine();
            }
            return "";
        }

        public string AddModel() // This method allows the user to add the droid's model type.
        {
            Console.WriteLine();
            Console.WriteLine("What is the droid's model?");
            return Console.ReadLine();
        }

        public string AddColor() // This method prompts the user to select a color for their droid.
        {
            Console.WriteLine();
            Console.WriteLine("What is the droid's color?");
            return Console.ReadLine();
        }

        public int AddLanguages() // If the droid is a Protocal, this method allows the user to enter
        {                        // how many languages it speaks.

            Console.WriteLine();
            Console.WriteLine("How many languages does the droid speak?");
            userInput = Console.ReadLine();

            try // This try/catch test checks to make sure the user entered an integer value.
            {
                Convert.ToInt32(userInput);
            }
            catch // If not, the method is called again to reaquire input.
            {
                Console.WriteLine();
                Console.WriteLine("Your choice was invalid.");
                AddLanguages();
            }
            return Convert.ToInt32(userInput);
        }

        public bool AddOptions() // This method handles all the boolean values required from the user.
        {
            Console.WriteLine("1 - Yes" + Environment.NewLine + "2 - No");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                return true; // If 1 is selected, the boolean is "true" (yes).
            }
            else if (userInput == "2")
            {
                return false;// If 2 is selected, the boolean is "false" (no).
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Your choice was invalid.");
                this.AddOptions();
            }
            return false;
        }

        public int AddShips() // If the droid is an Astromech, this method allows the user to select
        {                    // how many ships the droid can pilot.
                        
            Console.WriteLine();
            Console.WriteLine("How many ships can your droid pilot?");
            userInput = Console.ReadLine();

            try // Another try/catch test checks to make sure the user has entered an integer value.
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

        private void PrintMenu() // This method prints the program's main user menu.
        {
            Console.WriteLine("Please choose an option:" + Environment.NewLine +
                              "1 - Print the droid list." + Environment.NewLine +
                              "2 - Add a droid to the list." + Environment.NewLine + 
                              "3 - Exit the program.");
        }
    }
}
