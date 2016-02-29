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
        const decimal costPerLanguage = 30.00m;
        const decimal baseCost = 280.00m;


        public override string ToString()
        {
            return base.ToString();
        }

        public Protocol(string material, string model, string color, int numberLanguages) :
               base(material, model, color)
        {
            this.numberLanguages = numberLanguages;
        }

        //public abstract decimal CalculateTotalCost();
        public override decimal CalculateTotalCost()
        {
            return baseCost + costPerLanguage * numberLanguages;
        }
    }
}
