using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Ostrich : Birds
    {
        private bool scaredEasily;
        private int eggs;

        public Ostrich()
        {
            base.Flys = false;
            base.Toes = 4;
        }

        public bool ScaredEasily
        {
            set
            {
                scaredEasily = value;
            }
        }

        public int Eggs
        {
            set
            {
                eggs = value;
            }
        }
    }
}
