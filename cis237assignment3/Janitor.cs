using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    public class Janitor : Utility
    {
        bool trashCompactor;
        bool vacuum;

        public Janitor(string material, string model, string color, bool toolBox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
            : base(material, model, color, toolBox, computerConnection, arm)
        {
            this.trashCompactor = trashCompactor;
            this.vacuum = vacuum;
        }

        public override decimal CalculateTotalCost()
        {
            if (trashCompactor == true)
            {
                extraCost += 100.00m;
            }
            if (vacuum == true)
            {
                extraCost += 20.00m;
            }

           // totalCost = baseCost + extraCost;
            return baseCost + extraCost;
        }

        public override string ToString()
        {
            totalCost = this.CalculateTotalCost();
            return base.ToString();
        }
    }
}
