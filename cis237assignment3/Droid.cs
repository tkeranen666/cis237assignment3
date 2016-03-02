using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tim Keranen

namespace cis237assignment3
{
    public abstract class Droid : IDroid
    {
        protected string material;
        protected string model;
        protected string color;

        protected decimal baseCost;
        protected decimal totalCost;

        protected decimal extraCost = 0;

        protected decimal modelCost = 0;

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

        public Droid(string material, string model, string color)
        {
            this.material = material;
            this.model = model;
            this.color = color;

            modelCost = this.CalculateModelCost();

            baseCost = this.CalculateBaseCost();
        }

        public override string ToString()
        {
            return "Material               " + this.material + Environment.NewLine +
                   "Model                  " + this.model + Environment.NewLine +
                   "Color                  " + this.color + Environment.NewLine +
                   "Material Cost          " + this.baseCost.ToString() + " Credits" + 
                   Environment.NewLine +
                   "Model Cost             " + modelCost.ToString() + " Credits" + 
                   Environment.NewLine +
                   "Extra Costs            " + extraCost + " Credits" + 
                   Environment.NewLine +
                   "Total Cost             " + this.totalCost.ToString() + " Credits";
        }

        private decimal CalculateBaseCost()
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

        private decimal CalculateModelCost()
        {
            if (model == "HK Unit")
            {
                return 1000.00m;
            }
            else if (model == "R2 Unit")
            {
                return 500.00m;
            }
            else if (model == "T3 Unit")
            {
                return 450.00m;
            }
            else if (model == "V33 Unit")
            {
                return 250.00m;
            }
            else if (model == "Custom-built Unit" || model == "Custom-built" || model == "Custom Unit" ||
                     model == "Custom-made" || model == "Custom Built" || model == "Custom")
            {
                return 200.00m;
            }
            else
            {
                return 100.00m;
            }
        }

        public abstract decimal CalculateTotalCost();
    }
}
