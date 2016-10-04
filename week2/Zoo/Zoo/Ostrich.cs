using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Ostrich : Birds
    {
        private bool scaredEasily = true;
        private int eggs;

        public Ostrich()
        {
            base.Flys = false;        }

        public bool ScaredEasily
        {
            get
            {
                return scaredEasily;
            }
            set
            {
                scaredEasily = value;
            }
        }

        public int Eggs
        {
            get
            {

                return eggs;
            }
            set
            {
                eggs = value;
            }
        }
    }
}
