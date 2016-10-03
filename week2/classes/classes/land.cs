using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Land
    {
        private bool  disneyWorld = true;
        private bool  humans;
        private int spaceStations;
        private int godzilla;
        private string nameGodzilla;

        public Land(string newGodzillaName)
        {
            nameGodzilla = newGodzillaName;

        }

        public Land(int initialGodzilla, int InitialspaceStation)
        {
            Godzilla = initialGodzilla;
            SpaceStations = InitialspaceStation;
        }

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



        public string NameGodzilla

        {
            get
            {
                return nameGodzilla;
            }
            set
            {
                nameGodzilla = value;

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
                    godzilla = value;
                }
            }
        }
    }
}
