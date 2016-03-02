using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tim Keranen

namespace cis237assignment3
{
    public class Protocol : Droid
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
            extraCost = costPerLanguage * numberLanguages;
            return baseCost + costPerLanguage * numberLanguages + modelCost;
        }

        public override string ToString()
        {
            totalCost = this.CalculateTotalCost();
            return "PROTOCAL" + Environment.NewLine + 
                   "***************************************" + Environment.NewLine +
                   "Languages              " + numberLanguages.ToString() + 
                   Environment.NewLine + base.ToString();
        }
    }
}
