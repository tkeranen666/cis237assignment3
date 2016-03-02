using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tim Keranen

namespace cis237assignment3
{
    public class Utility : Droid // The Utility derives from Droid, and handles the values
    {                           // shared by Astromech and Janitor.
        protected bool toolBox;
        protected bool computerConnection;
        protected bool arm;

        protected string[] options = new string[6]; // This array sets string values for the boolean choices
                                                   // displayed in the ToString() method. It is protected to
                                                  //  allow it to be inherited. 
        public Utility() // Default constructor.
        {
        }

        public Utility(string material, string model, string color, bool toolBox, bool computerConnection, bool arm)
            : base(material, model, color) // Six parameter constructor using passed-in fields from the Droid class
        {
            options[0] = "No";
            options[1] = "No"; // The options string array values are set to "No" (false) by default unless their boolean
            options[2] = "No"; // counterparts are set to true.
            options[3] = "No";
            options[4] = "No";
            options[5] = "No";

            this.toolBox = toolBox;
            this.computerConnection = computerConnection;
            this.arm = arm;
        }

        public override decimal CalculateTotalCost() // For some reason, I could not get this method to work for the life
        {                                           // of me, so I moved to calculations to Utilities derived classes.
            //if (toolBox == true)                 //  Is it because the derived classes are overriding it?
            //{
            //    extraCost += 60.00m;
            //    options[0] = "Yes";
            //}
            //if (computerConnection == true)
            //{
            //    extraCost += 30.00m;
            //    options[1] = "Yes";
            //}
            //if (arm == true)
            //{
            //    extraCost += 50.00m;
            //    options[2] = "Yes";
            //}

            return baseCost + extraCost + modelCost;
        }

        public override string ToString() // Utility overrides Droid's ToString() method and adds the new values to it.
        {
            //totalCost = this.CalculateTotalCost();
            return "          Has Toolbox  " + options[0] + Environment.NewLine +
                   "  Connect to Computer  " + options[1] + Environment.NewLine +
                   "              Has Arm  " + options[2] + Environment.NewLine + base.ToString();
        }
    }
}
