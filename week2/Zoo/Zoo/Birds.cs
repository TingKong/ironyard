using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Birds : Animals
    {
        private bool flys = true;
        private int toes;


        public Birds()
        {
            base.NumOfLegs = 2;
            base.Location = "land";
        }

        public bool Flys
        {
            get
            {
                return flys;
            }
            set
            {
               flys = value;
            }
        }

        public int Toes
        {
            
           get
            {
                return toes;
            }
            set
            {
                toes = value;
            }

        }


    }
}
