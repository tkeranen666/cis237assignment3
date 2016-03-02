using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tim Keranen

namespace cis237assignment3
{
    public class Astromech : Utility // Astromech derives from Utility, inheriting its passed values.
    {
        private bool fireExtinguisher; // Protection level of values are private because they will not be inherited.
        private int numberShips;
        private const decimal costPerShips = 0.50m;

        public Astromech()
        {
        }

        public Astromech(string material, string model, string color, bool toolBox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
            : base(material, model, color, toolBox, computerConnection, arm) // 8-parameter constructor using passed values from Utility.
        {
            this.fireExtinguisher = fireExtinguisher;
            this.numberShips = numberShips;
        }

        public override decimal CalculateTotalCost()
        {
            // Utility's extra cost and total cost calculations are done here and in Janitor, because they were not working in Utility.
            //**************************************
            if (toolBox == true) 
            {                   
                extraCost += 60.00m;
                options[0] = "Yes";
            }
            if (computerConnection == true)
            {
                extraCost += 30.00m;
                options[1] = "Yes";
            }
            if (arm == true)
            {
                extraCost += 50.00m;
                options[2] = "Yes";
            }
            //***************************************

            if (fireExtinguisher == true)
            {
                options[3] = "Yes"; // If the droid has a fire extinguisher, it's fee is added to the total cost.
                extraCost += 30;
            }
            extraCost += costPerShips * numberShips; // The product of the cost of each ship in the droid's 
                                                    // memory and the number of ships are added to the extra cost.

            return baseCost + extraCost + modelCost; // And the total cost is calculated by adding all the costs together.
        }

        public override string ToString() // Astromech overrides Utility's ToString() method and adds the new values to it.
        {
            totalCost = this.CalculateTotalCost(); // CalculateTotalCost() override methd is called to get the full cost.
            return "ASTROMECH" + Environment.NewLine +
                   "******************************************" + Environment.NewLine +
                   "Has Fire Extinguisher  " + options[3] + Environment.NewLine + 
                   "Ships Droid Can Pilot  " + numberShips.ToString() + 
                   Environment.NewLine + base.ToString();
        }
    }
}
