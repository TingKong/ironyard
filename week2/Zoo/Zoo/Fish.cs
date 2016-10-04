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
    

    public Fish()
    {
        base.NumOfLegs = 2;
    }

        public bool LivesInWater
        {
            get
            {
                return livesInWater;
            }

            set
            {
                livesInWater = value;
            }
        }

        public bool Gills
        {
            get
            {
                return gills;
            }

            set
            {
                gills = value;
            }
        }

    }
}
