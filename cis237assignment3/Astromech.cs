using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    public class Astromech : Utility
    {
        bool fireExtinguisher;
        protected int numberShips;
        protected const decimal costPerShips = 50.00m;

        public Astromech(string material, string model, string color, bool toolBox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
            : base(material, model, color, toolBox, computerConnection, arm)
        {
            this.fireExtinguisher = fireExtinguisher;
            this.numberShips = numberShips;
        }

        public override decimal CalculateTotalCost()
        {
            if (fireExtinguisher == true)
            {
                extraCost += 30;
            }

            //totalCost = baseCost + extraCost + costPerShips * numberShips;
            return baseCost + extraCost + costPerShips * numberShips;
        }

        public override string ToString()
        {
            return "Ships Can Pilot: " + numberShips.ToString() + Environment.NewLine + base.ToString();
        }
    }
}
