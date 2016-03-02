using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tim Keranen

namespace cis237assignment3
{
    interface IDroid // The IDroid interface
    {
        decimal CalculateTotalCost();

        decimal TotalCost
        {
            get;
            set;
        }
    }
}
