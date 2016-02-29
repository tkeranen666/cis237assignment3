using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    public class Astromech : Utility
    {
        bool fireExtinguisher;
        int numberShips;
        const decimal costPerShips = 50.00m;
        const decimal baseCost = 320.00m;


        public override string ToString()
        {
            return base.ToString();
        }

        public Astromech(string material, string model, string color, bool toolBox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
            : base(material, model, color, toolBox, computerConnection, arm)
        {
            this.fireExtinguisher = fireExtinguisher;
            this.numberShips = numberShips;
        }

        public decimal CalculateCost()
        {




            return 1.00m;
        }
        //public override decimal CalculateTotalCost()
        //{
        //    return baseCost + costPerShips * numberShips;
        //}
    }
}
