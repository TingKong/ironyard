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
        private bool matesForLife = true;

        public Penguins()
        {
            base.LivesInWater = false;
            base.Gills = false;
            base.Location = "land/sea";

        }
        public bool MatesForLife
        {
            get
            {
                return matesForLife;
            }
        }

        public int Slides
        {
            get
            {
                return slides;
            }
            set
            {
                slides = value;
            }
        }

    }
}
