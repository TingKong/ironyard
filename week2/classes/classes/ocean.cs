using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Ocean
    {

        private bool megalodons = true;
        private int warShips;
        private int giantOctopus;
        private bool sinkenShips;
        private string nemo;

        public Ocean(string nemoName)
        {
            nemo = nemoName;
        }

        public Ocean(int initialGaintOctopus, int initialWarShips )
        {
            giantOctopus = initialGaintOctopus;
            warShips = initialWarShips;

        }

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

        public string Nemo

        {
            get
            {
                return nemo;
            }
            set
            {
                nemo = value;
            }
        }
    }
}
