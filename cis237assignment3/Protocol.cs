using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {
        int numberLanguages;
        const decimal costPerLanguage = 30.00m;


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
            return 1.00m; //costPerLanguage * Droid(baseCost);
        }
    }
}
