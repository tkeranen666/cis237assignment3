using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tim Keranen

namespace cis237assignment3
{
    public abstract class Droid : IDroid // The Droid class is abstract so it can implement
    {                                   // the IDroid interface and be derived by other classes
        protected string material;
        protected string model; // Backing fields to be used by other classes are set to protected.
        protected string color;

        protected decimal extraCost = 0; // The extraCost variable is used to determine additional
        // fees like the cost of additional parts for Utility droids.

        protected decimal modelCost = 0;
        protected decimal baseCost;
        protected decimal totalCost;

        private const decimal COST_1 = 3000.00m;// These constant fields are used to set the base
        private const decimal COST_2 = 2500.00m;// cost for each droid, based on material. They
        private const decimal COST_3 = 1000.00m;// are set to private because they will not be used
        private const decimal COST_4 = 500.00m;//  outside of Droid.
                                        
        public string Material
        {
            get { return material; } // Properties are set for the backing fields.
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

        public decimal ExtraCost
        {
            get { return extraCost; }
            set { extraCost = value; }
        }

        public decimal ModelCost
        {
            get { return modelCost; }
            set { modelCost = value; }
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

        public Droid() // Droid's default constructor.
        {
        }

        public Droid(string material, string model, string color) // 3-parameter constructor for
        {                                                        // passing values.
            this.material = material;
            this.model = model;
            this.color = color;

            baseCost = this.CalculateBaseCost(); // The CalculateBaseCost() method is called to set the
                                                // cost of the material using the constant feilds.

            modelCost = this.CalculateModelCost(); // CalculateModelCost() is called to assign costs to
        }                                         // each droid model.

        public override string ToString() // ToString() method creates a formatted string value that will
        {                                // represent each droid in the droidList array.

            return "             Material  " + this.material + Environment.NewLine +
                   "                Model  " + this.model + Environment.NewLine +
                   "                Color  " + this.color + Environment.NewLine +
                   "        Material Cost  " + this.baseCost.ToString() + " Credits" + 
                   Environment.NewLine +
                   "           Model Cost  " + modelCost.ToString() + " Credits" + 
                   Environment.NewLine +
                   "          Extra Costs  " + extraCost + " Credits" + 
                   Environment.NewLine +
                   "           Total Cost  " + this.totalCost.ToString() + " Credits";
        }

        private decimal CalculateBaseCost()
        {
            if (material == "Thermasteel") // Base costs are set for each droid depending on material.
            {
                return COST_1;
            }
            else if (material == "Plasteel")
            {
                return COST_2;
            }
            else if (material == "Plastoid Alloy")
            {
                return COST_3;
            }
            else
            {
                return COST_4;
            }
        }

        private decimal CalculateModelCost()
        {
            if (model == "HK Unit") // Certain droid models are more expensive than others. Models that
            {                      // do not match to specified ones will have a standard fee of 100
                return 1000.00m;  //  credits.
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

        public abstract decimal CalculateTotalCost(); // CalculateTotalCost() method is implemented from
    }                                                // IDroid and used to get the full price for each droid.
}
