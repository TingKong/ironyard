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
        private int toes;


        public Birds()
        {
            base.NumOfLegs = 2;
            base.Location = "Land/Sky";
        }

        public bool Flys
        {
            set
            {
               flys = value;
            }
        }

        public int Toes
        {
           set
            {
                toes = value;
            }

        }


    }
}
