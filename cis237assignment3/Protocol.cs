using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    public class Protocol : Droid
    {
        int numberLanguages;
        const decimal costPerLanguage = 0.01m;

        public Protocol(string material, string model, string color, int numberLanguages) :
               base(material, model, color)
        {
            this.numberLanguages = numberLanguages;
        }

        public override decimal CalculateTotalCost()
        {
            return baseCost + costPerLanguage * numberLanguages;
        }

        public override string ToString()
        {
            totalCost = this.CalculateTotalCost();
            return "Languages:        " + numberLanguages.ToString() + Environment.NewLine + base.ToString();
        }
    }
}
