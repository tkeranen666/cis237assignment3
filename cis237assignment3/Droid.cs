using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    public abstract class Droid : IDroid
    {
        protected string material;
        protected string model;
        protected string color;

        protected decimal baseCost;
        protected decimal totalCost;

        private const decimal COST_1 = 3000.00m;
        private const decimal COST_2 = 2500.00m;
        private const decimal COST_3 = 1000.00m;

        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public decimal BaseCost
        {
            get { return baseCost; }
            set { baseCost = value; }
        }

        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public Droid()
        {
        }

        public Droid(string material, string model, string color/*, decimal baseCost*/)
        {
            this.material = material;
            this.model = model;
            this.color = color;
            //this.baseCost = baseCost;

            baseCost = this.CalculateBaseCost();
            //totalCost = this.CalculateTotalCost();
        }

        public string InfoList()
        {
            return this.material + ", " + this.model + ", " + this.color; // + ", cost of droid: " + 
                  // this.baseCost.ToString("N") + ", total cost of purchase: " + this.totalCost.ToString("N");
        }

        public override string ToString()
        {
            return "Material:         " + this.material + Environment.NewLine +
                   "Model:            " + this.model + Environment.NewLine +
                   "Color:            " + this.color + Environment.NewLine +
                   "Material Cost:    " + this.baseCost.ToString() + " Credits" + 
                   Environment.NewLine +
                   "Total Cost:       " + this.totalCost.ToString() + " Credits";
        }

        public decimal CalculateBaseCost()
        {
            if (material == "Carbon-steel Alloy")
            {
                return COST_1;
            }
            else if (material == "Plasteel")
            {
                return COST_2;
            }
            else if (material == "Aluminum-steel Alloy")
            {
                return COST_3;
            }
            else
            {
                return 500.00m;
            }
        }

        public abstract decimal CalculateTotalCost();
        //{
        //    return totalCost;
        //}
    }
}
