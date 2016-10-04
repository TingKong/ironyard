using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Owl : Birds
    {
        private bool nocturnal = true;
        private string food;

        public Owl()
        {

        base.Flys = true;
        base.Toes = 4;
        }

        public bool Nocturnal
        {
            get
            {
                return nocturnal;
            }
            set
            {
                nocturnal = value;
            }

        }

        public string Food
        {
            get
            {
                return food;
            }
            set
            {
                food = value;
            }

        }

    }
}
