using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Mammals : Animals
    {
        private bool meatEaters;
        private bool furry;
    
    public Mammals()
    {
        base.NumOfLegs = 2;
        base.Location = "land";
    }

        public bool MeatEaters
        {
            get
            {
                return meatEaters;
            }
            set
            {
                meatEaters = value;
            }
        }

        public bool Furry
        {
            get
            {
                return furry;
            }
            
            set
            {
                furry = value;
            }

        }

    }

}
