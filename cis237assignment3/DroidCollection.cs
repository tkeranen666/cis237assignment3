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

        public void AddInitialDroids() // Add items to array so it can be printed
        {
            droidList[0] = new Astromech("Carbon-steel Alloy", "R2-D2", "Blue", true, true, true, true, 25);
            droidList[1] = new Protocol("Plasteel", "C-3PO", "Gold", 6000000);
            droidList[2] = new Astromech("Aluminum-steel Alloy", "Whistler", "Green", true, true, true, false, 10);
            droidList[3] = new Protocol("Carbon-steel Alloy", "HK-47", "Rusty Orange", 40000);
            droidList[4] = new Astromech("Plasteel", "T3-M4", "Silver", false, true, true, false, 15);
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
                    Console.WriteLine("Droid #" + counter.ToString());
                    Console.WriteLine(droid.ToString());
                }
                counter++;
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void AddDroid()
        {

            UserInterface UI = new UserInterface();


        }
    }
}
