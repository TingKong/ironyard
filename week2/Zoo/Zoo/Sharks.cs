using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Sharks : Fish
    {
        private int teeth;
        private int weight;

        public Sharks()
        {
            base.LivesInWater = true;
            base.Gills = true;
        }

        public int Teeth
        {
            get
            {
                return teeth;
            }

        }

    }
}
