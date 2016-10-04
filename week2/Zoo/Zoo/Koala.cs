using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Koala : Mammals
    {
        private string hugs;
        private string trees;

        public Koala()
        {
            base.MeatEaters = false;
            base.Furry = true;
        }
        public string Hugs
        {
            get
            {
                return hugs;
            }
            set
            {
                hugs = value;
            }
        }

        public string Trees
        {
            get
            {
                return trees;
            }
            set
            {
                trees = value;
            }

        }

    }
}
