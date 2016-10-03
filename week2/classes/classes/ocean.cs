using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class ocean
    {

        private bool megalodons = true;
        private int warShips;
        private bool pollution;
        private int giantOctopus;
        private bool sinkenShips;



        public bool Megalodons

        {
            get
            {
                return megalodons;
            }
            set
            {
                megalodons = value;
            }
        }

        public int WarShips
        {
            get
            {
                return warShips;
            }

            set
            {
                if (value < 1)
                {
                    warShips = 1;
                }
                else
                {
                    warShips = value;
                }
            }
        }

        public bool Pollution

        {
            get
            {
                return pollution;
            }
        }

        public int GiantOctopus
        {
            get
            {
                return giantOctopus;
            }

            set
            {
                if (value < 1)
                {
                    giantOctopus = 1;
                }
                else
                {
                    giantOctopus = value;
                }
            }
        }

        public bool SinkenShips

        {
            get
            {
                return sinkenShips;
            }
            set
            {
               sinkenShips = value;
            }
        }

    }
}
