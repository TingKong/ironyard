using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Mammals : Animals
    {
        private bool warmBlooded;
        private bool furry;
    }

    public Mammals()
    {
        base.numOfLegs = 2;
    }
}
