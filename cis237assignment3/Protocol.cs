using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tim Keranen

namespace cis237assignment3
{
    public class Protocol : Droid // Protocal derives from Droid, inherits values, and overrides methods.
    {
        private int numberLanguages; // These variables are set to private because they do not need
        private const decimal costPerLanguage = 0.01m; // to be inherited by other classes.

        public Protocol() // Default constructor.
        {
        }

        public Protocol(string material, string model, string color, int numberLanguages) :
               base(material, model, color) // 4-parameter constructor using values passed in by the 
        {                                  // Droid class.
            this.numberLanguages = numberLanguages;
        }

        public override decimal CalculateTotalCost()
        {
            // extraCost is determined by multiplying the cost of each language by the number of languages.
            extraCost = costPerLanguage * numberLanguages; 
            return baseCost + extraCost + modelCost; // All the costs are added together to get the total cost.
        }

        public override string ToString() // Protocal overrides Droid's ToString() method and adds the new values to it.
        {
            totalCost = this.CalculateTotalCost(); // CalculateTotalCost() override methd is called to get the full cost.
            return "PROTOCAL" + Environment.NewLine + 
                   "*******************************************" + Environment.NewLine +
                   "            Languages  " + numberLanguages.ToString() + 
                   Environment.NewLine + base.ToString();
        }
    }
}
