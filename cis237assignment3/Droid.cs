using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {
        protected string material;
        protected string model;
        protected string color;
        protected decimal baseCost;
        protected decimal totalCost;

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
            set { baseCost = value;}
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
        }

        public string InfoList()
        {
            return this.material + ", " + this.model + ", " + this.color + ", cost of droid: " + 
                   this.baseCost.ToString("N") + ", total cost of purchase: " + this.totalCost.ToString("N");
        }

        public abstract decimal CalculateTotalCost();

        public override string ToString()
        {
            return this.material + " " + this.model + " " + this.color;
        }
    }
}
