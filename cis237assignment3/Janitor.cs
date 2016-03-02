using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tim Keranen

namespace cis237assignment3
{
    public class Janitor : Utility // Janitor derives from Utility, inheriting its passed values.
    {
        private bool trashCompactor;
        private bool vacuum; // Protection level of values are private because they will not be inherited.

        public Janitor()
        {
        }

        public Janitor(string material, string model, string color, bool toolBox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
            : base(material, model, color, toolBox, computerConnection, arm) // 8-parameter constructor using passed values from Utility.
        {
            this.trashCompactor = trashCompactor;
            this.vacuum = vacuum;
        }

        public override decimal CalculateTotalCost()
        {
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

            if (trashCompactor == true)
            {
                options[4] = "Yes";
                extraCost += 100.00m; // An additional cost is added to extraCost for each
            }                        // boolean value set to "true".
            if (vacuum == true)
            {
                options[5] = "Yes";
                extraCost += 20.00m;
            }

            return baseCost + extraCost + modelCost; // And the total cost is calculated by adding all the costs together.
        }

        public override string ToString() // Janitor overrides Utility's ToString() method and adds the new values to it.
        {
            totalCost = this.CalculateTotalCost(); // CalculateTotalCost() override methd is called to get the full cost.
            return "JANITOR" + Environment.NewLine +
                   "*******************************************" + Environment.NewLine +
                   "  Has Trash Compactor  " + options[4] + Environment.NewLine +
                   "           Has Vacuum  " + options[5] + Environment.NewLine + base.ToString();
        }
    }
}
