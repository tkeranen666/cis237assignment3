using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    public class DroidCollection
    { 
        //static void Main(string[] args)
        //{
        
        IDroid[] droidList = new Droid[100];

        public void AddInitialDroids()
        {
            droidList[0] = new Astromech("Steel Alloy", "R2-D2", "Blue", true, true, true, true, 25);
            droidList[1] = new Protocol("Plasteel Alloy", "C-3PO", "Gold", 6000000);
            droidList[2] = new Astromech("Aluminum-steel Alloy", "Whistler", "Green", true, true, true, false, 10);
            droidList[3] = new Protocol("Carbon-steel Alloy", "HK-47", "Rusty Orange", 40000);
            droidList[4] = new Astromech("Plasteel Alloy", "T3-M4", "Silver", false, true, true, false, 15);
            droidList[5] = new Janitor("Aluminum-steel Alloy", "V33-Q7", "Yellow", true, false, false, true, true);
        }

        public void PrintList()
        {
            //Console.WriteLine("Hello");
            //if (droidList == null)
            //{
            //    droidList[0] = new Astromech("Steel Alloy", "R2-D2", "Blue", true, true, true, true, 25);
            //    droidList[1] = new Protocol("Plasteel Alloy", "C-3PO", "Gold", 6000000);
            //    droidList[2] = new Astromech("Aluminum-steel Alloy", "Whistler", "Green", true, true, true, false, 10);
            //    droidList[3] = new Protocol("Carbon-steel Alloy", "HK-47", "Rusty Orange", 40000);
            //    droidList[4] = new Astromech("Plasteel Alloy", "T3-M4", "Silver", false, true, true, false, 15);
            //    droidList[5] = new Janitor("Aluminum-steel Alloy", "V33-Q7", "Yellow", true, false, false, true, true);
            //}
            //else
            //{
            foreach (Droid droid in droidList)
            {
                if (droid != null)
                {
                    Console.WriteLine();
                    Console.WriteLine(droid.ToString());
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            //}
        }
    }
}
