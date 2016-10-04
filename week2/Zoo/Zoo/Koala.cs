using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Koala : Mammals
    {
        private int slides;
        private bool matesForLife;

        public Koala()
        {
            base.MeatEaters = false;
            base.Furry = true;
        }
        public int Slides
        {
            set
            {
                slides = value;
            }
        }

        public bool MatesForLife
        {
            set
            {
                matesForLife = value;
            }

        }

    }
}
