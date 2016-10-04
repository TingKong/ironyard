using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Fish : Animals
    {
        private bool livesInWater;
        private bool gills;
    }

    public Fish()
    {
        base.numOfLegs = 2;
    }
}
