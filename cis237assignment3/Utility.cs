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


        public override string ToString()
        {
            return base.ToString();
        }

        public Utility(string material, string model, string color, bool toolBox, bool computerConnection, bool arm)
            : base(material, model, color)
        {
            this.toolBox = toolBox;
            this.computerConnection = computerConnection;
            this.arm = arm;
        }

        public override decimal CalculateTotalCost()
        {
            return 1.00m;
        }
        //public decimal CalculateTotalCost()
        //{
        //    return 1.00m;
        //}
    }
}
