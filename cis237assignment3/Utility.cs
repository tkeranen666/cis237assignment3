using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    public class Utility : Droid
    {
        bool toolBox;
        bool computerConnection;
        bool arm;

        protected decimal extraCost = 0;

        public Utility(string material, string model, string color, bool toolBox, bool computerConnection, bool arm)
            : base(material, model, color)
        {
            this.toolBox = toolBox;
            this.computerConnection = computerConnection;
            this.arm = arm;
        }

        public override decimal CalculateTotalCost()
        {
            if (toolBox == true)
            {
                extraCost += 60.00m;
            }
            if (computerConnection == true)
            {
                extraCost += 30.00m;
            }
            if (arm == true)
            {
                extraCost += 50.00m;
            }

            //totalCost = baseCost + extraCost;
            return baseCost + extraCost;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
