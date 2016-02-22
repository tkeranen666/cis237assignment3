using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor : Utility
    {
        bool trashCompactor;
        bool vacuum;


        public override string ToString()
        {
            return base.ToString();
        }

        public Janitor(string material, string model, string color, bool toolBox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
            : base(material, model, color, toolBox, computerConnection, arm)
        {
            this.trashCompactor = trashCompactor;
            this.vacuum = vacuum;
        }

        public override decimal CalculateTotalCost()
        {
            return 1.00m;
        }
    }
}
