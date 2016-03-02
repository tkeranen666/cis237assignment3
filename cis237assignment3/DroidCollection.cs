using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tim Keranen

namespace cis237assignment3
{
    public class DroidCollection // The DroidCollection class handles and processes the droidList array.
    { 
        IDroid[] droidList = new Droid[100];
        private int droidIndex = 6; // This index keeps track of the current number of items in the array.
        //int droidIndex = 98;

        public void AddInitialDroids() // Add items to array so it can be printed
        {
            droidList[0] = new Astromech("Thermasteel", "R2 Unit", "Blue", true, true, true, true, 250);
            droidList[1] = new Protocol("Plasteel", "Custom-built Unit", "Gold", 6000000);
            droidList[2] = new Astromech("Thermasteel", "R2 Unit", "Green", true, true, true, false, 50);
            droidList[3] = new Protocol("Plastoid Alloy", "HK Unit", "Rusty Orange", 400000);
            droidList[4] = new Astromech("Plasteel", "T3 Unit", "Silver", false, true, true, false, 50);
            droidList[5] = new Janitor("Plastoid Alloy", "V33 Unit", "Yellow", true, false, false, true, true);
        }

        public void PrintList() // PrintList() method prints the droids currently in the array
        {
            int counter = 0;
            foreach (Droid droid in droidList) // The program goes through each item in the array and prints it using a foreach loop.
            {
                if (droid != null) // The program checks to make sure the array has values in it before printing.
                {

                    Console.WriteLine();
                    Console.Write("            Droid #" + (counter + 1).ToString() + " -- ");
                    Console.WriteLine(droid.ToString());
                    Console.WriteLine();
                }
                counter++;
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void AddDroid() // This method is for selecting which type of droid the user to add to the list.
        {
            if (droidIndex < 100) // The user can print a new droid as long as there are less than 100 items in the array.
            {                    // If the array is full, then the user can not add any more items/droids to it.

                UserInterface UI = new UserInterface(); // The program calls a new instance of UserInterface.

                string droidType = UI.AddDroid();
                string material = UI.AddMaterial(); // Fields are created to hold the appropriate values passed by the UI class.
                string model = UI.AddModel();
                string color = UI.AddColor();

                bool toolBox;
                bool connect; // These fields are left unnassigned if the user create a Protocal droid, but will be used if the
                bool arm;    // user creates an Astromech or a Janitor.

                if (droidType == "Protocal") // If the user selects "Protocal", then a new Protocal droid is added to 
                {                           // the array using the values selected by the user.

                    int languages = UI.AddLanguages(); // Program recieves the number of languages the droid speaks from the user.

                    droidList[droidIndex] = new Protocol(material, model, color, languages); // The program generates the new item using 
                }                                                                           //the droidIndex variable as a place-holder.

                else if (droidType == "Astromech") // If the user selects "Astromech", then a new Astromech droid is added to the array.
                {
                    Console.WriteLine();
                    Console.WriteLine("Does your droid have a toolbox?");
                    toolBox = UI.AddOptions(); // The program uses the fields created before to hold boolean values selected by the user.

                    Console.WriteLine("Can your droid connect to a computer console?");
                    connect = UI.AddOptions();

                    Console.WriteLine("Does your droid have an arm?");
                    arm = UI.AddOptions();

                    Console.WriteLine("Does your droid have a fire extinguisher?");
                    bool extingusher = UI.AddOptions();

                    int ships = UI.AddShips(); // Additional values appropriate for the Astromech are selcected by the user.

                    // The progams generates the new Astromech array item.
                    droidList[droidIndex] = new Astromech(material, model, color, toolBox, connect, arm, extingusher, ships);
                }

                else if (droidType == "Janitor") // If the user selects "Janitor", then a new Janitor droid is added to the array.
                {
                    Console.WriteLine();
                    Console.WriteLine("Does your droid have a toolbox?"); // The program uses the same process to recieve values
                    toolBox = UI.AddOptions();                           // generated by the user.

                    Console.WriteLine("Can your droid connect to a computer console?");
                    connect = UI.AddOptions();

                    Console.WriteLine("Does your droid have an arm?");
                    arm = UI.AddOptions();

                    Console.WriteLine("Does your droid have a trash compactor?");
                    bool compactor = UI.AddOptions();

                    Console.WriteLine("Does your droid have a vacuum?");
                    bool vacuum = UI.AddOptions();

                    // The progams generates the new Janitor array item.
                    droidList[droidIndex] = new Janitor(material, model, color, toolBox, connect, arm, compactor, vacuum);
                }
                droidIndex += 1; // The array's index place holder adds 1 each time a new array item is created.
            }

            else // If the array is full, the user will be displayed with a warning message, and they will not be allowed to add any more
            {   // items to the array.
                Console.WriteLine("WARNING: The list is full. No more droids can be added.");
            }
        }

    }
}
