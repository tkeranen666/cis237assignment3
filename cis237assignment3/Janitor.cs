using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tim Keranen

namespace cis237assignment3
{
    public class Janitor : Utility
    {
        bool trashCompactor;
        bool vacuum;

        public Janitor()
        {
        }

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
                options[4] = "Yes";
                extraCost += 100.00m;
            }
            if (vacuum == true)
            {
                options[5] = "Yes";
                extraCost += 20.00m;
            }

            return baseCost + extraCost + modelCost;
        }

        public override string ToString()
        {
            totalCost = this.CalculateTotalCost();
            return "JANITOR" + Environment.NewLine +
                   "***************************************" + Environment.NewLine +
                   "Has Trash Compactor    " + options[4] + Environment.NewLine + 
                   "Has Vacuum             " + options[5] + Environment.NewLine + base.ToString();
        }
    }
}
