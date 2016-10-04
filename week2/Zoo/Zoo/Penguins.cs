using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Penguins : Fish
    {
        private int slides;
        private bool matesForLife;

        public Penguins()
        {
            base.LivesInWater = false;
            base.Gills = false;
        }
        public bool MatesForLife
        {
            get
            {
                return MatesForLife;
            }
        }

  public int Slides
        {
            get
            {
                return slides;
            }

        }

    }
}
