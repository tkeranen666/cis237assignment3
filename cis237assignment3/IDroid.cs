using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tim Keranen

namespace cis237assignment3
{
    interface IDroid // The IDroid interface allows the abstract Droid class to implement it
    {               // and override it's CalculateTotalCost() method

        decimal CalculateTotalCost();

        decimal TotalCost // This is the property for the total cost.
        {
            get;
            set;
        }
    }
}
