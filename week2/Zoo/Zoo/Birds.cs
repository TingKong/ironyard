using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Birds : Animals
    {
        private bool flys;
        private bool nest;


        public Birds()
        {
            base.NumOfLegs = 2;
            base.Location = "Sky";
        }

        public bool Flys
        {
            get
            {
                return flys;
            }
        }


    }
}
