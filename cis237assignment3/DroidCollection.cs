using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    public class DroidCollection
    { 
        IDroid[] droidList = new Droid[100];
        //int droidIndex = 6;
        int droidIndex = 98;

        public void AddInitialDroids() // Add items to array so it can be printed
        {
            droidList[0] = new Astromech("Carbon-steel Alloy", "R2-D2", "Blue", true, true, true, true, 250);
            droidList[1] = new Protocol("Plasteel", "C-3PO", "Gold", 6000000);
            droidList[2] = new Astromech("Aluminum-steel Alloy", "Whistler", "Green", true, true, true, false, 50);
            droidList[3] = new Protocol("Carbon-steel Alloy", "HK-47", "Rusty Orange", 400000);
            droidList[4] = new Astromech("Plasteel", "T3-M4", "Silver", false, true, true, false, 50);
            droidList[5] = new Janitor("Aluminum-steel Alloy", "V33-Q7", "Yellow", true, false, false, true, true);
        }

        public void PrintList() // PrintList() method prints the droids currently in the array
        {
            int counter = 0;
            foreach (Droid droid in droidList)
            {
                if (droid != null)
                {

                    Console.WriteLine();
                    Console.WriteLine("Droid #" + (counter + 1).ToString());
                    Console.WriteLine(droid.ToString());
                }
                counter++;
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void AddDroid()
        {
            if (droidIndex < 100)
            {
                UserInterface UI = new UserInterface();

                string droidType = UI.AddDroid();
                string material = UI.AddMaterial();
                string model = UI.AddModel();
                string color = UI.AddColor();

                bool toolBox;
                bool connect;
                bool arm;

                if (droidType == "Protocal")
                {
                    int languages = UI.AddLanguages();

                    //Console.WriteLine(droidType + " " + material + " " + model + " " + color + " " + languages);
                    droidList[droidIndex] = new Protocol(material, model, color, languages);
                }

                else if (droidType == "Astromech")
                {
                    Console.WriteLine("Does your droid have a toolbox?");
                    toolBox = UI.AddOptions();

                    Console.WriteLine("Can your droid connect to a computer console?");
                    connect = UI.AddOptions();

                    Console.WriteLine("Does your droid have an arm?");
                    arm = UI.AddOptions();

                    Console.WriteLine("Does your droid have a fire extinguisher?");
                    bool extingusher = UI.AddOptions();

                    //Console.WriteLine("How many ships can your droid pilot?");
                    int ships = UI.AddShips();

                    //Console.WriteLine(droidType + " " + material + " " + model + " " + color);
                    //Console.WriteLine(toolBox.ToString() + " " + connect.ToString() + " " + arm.ToString() + " " + extingusher.ToString() + " " + ships);
                    droidList[droidIndex] = new Astromech(material, model, color, toolBox, connect, arm, extingusher, ships);
                }

                else if (droidType == "Janitor")
                {
                    Console.WriteLine("Does your droid have a toolbox?");
                    toolBox = UI.AddOptions();

                    Console.WriteLine("Can your droid connect to a computer console?");
                    connect = UI.AddOptions();

                    Console.WriteLine("Does your droid have an arm?");
                    arm = UI.AddOptions();

                    Console.WriteLine("Does your droid have a trash compactor?");
                    bool compactor = UI.AddOptions();

                    Console.WriteLine("Does your droid have a vacuum?");
                    bool vacuum = UI.AddOptions();

                    //Console.WriteLine(droidType + " " + material + " " + model + " " + color);
                    //Console.WriteLine(toolBox.ToString() + " " + connect.ToString() + " " + arm.ToString() + " " + compactor.ToString() + " " + vacuum.ToString());
                    droidList[droidIndex] = new Janitor(material, model, color, toolBox, connect, arm, compactor, vacuum);
                }
                droidIndex += 1;
            }

            else
            {
                Console.WriteLine("WARNING: The list is full. No more droids can be added.");
            }
        }

    }
}
