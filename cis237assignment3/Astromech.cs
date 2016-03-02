using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tim Keranen

namespace cis237assignment3
{
    public class Astromech : Utility
    {
        private bool fireExtinguisher;
        protected int numberShips;
        protected const decimal costPerShips = 50.00m;

        public Astromech()
        {
        }

        public Astromech(string material, string model, string color, bool toolBox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
            : base(material, model, color, toolBox, computerConnection, arm)
        {
            this.fireExtinguisher = fireExtinguisher;
            this.numberShips = numberShips;
        }

        public override decimal CalculateTotalCost()
        {
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

            if (fireExtinguisher == true)
            {
                options[3] = "Yes";
                extraCost += 30;
            }
            extraCost += costPerShips * numberShips;

            return baseCost + extraCost + modelCost;
        }

        public override string ToString()
        {
            totalCost = this.CalculateTotalCost();
            return "ASTROMECH" + Environment.NewLine +
                   "***************************************" + Environment.NewLine +
                   "Has Fire Extinguisher  " + options[3] + Environment.NewLine + 
                   "Ships Droid Can Pilot  " + numberShips.ToString() + 
                   Environment.NewLine + base.ToString();
        }
    }
}
