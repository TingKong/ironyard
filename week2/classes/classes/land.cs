using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class land
    {
        private bool  disneyWorld;
        private bool  humans;
        private bool pollution;
        private int spaceStations;
        private int godzilla;

        public bool DisneyWorld

        {
            get
            {
                return disneyWorld;
            }
            set
            {
                disneyWorld = value;
            }
        }

        public bool Humans

        {
            get
            {
                return humans;
            }
            set
            {
                humans = value;
            }
        }

        public bool Pollution

        {
            get
            {
                return pollution;
            }
            
        }

        public int SpaceStations
        {
            get
            {
                return spaceStations;
            }

            set
            {
                if (value < 1)
                {
                    spaceStations = 1;
                }
                else
                {
                    spaceStations = value;
                }
            }
        }

        public int Godzilla
        {
            get
            {
                return godzilla;
            }

            set
            {
                if (value < 1)
                {
                    godzilla = 1;
                }
                else
                {
                    godzilla; = value;
                }
            }
        }
    }
}
