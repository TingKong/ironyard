using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Owl : Birds
    {
        private bool nocturnal;
        private string food;

        public Owl()
        {

        base.Flys = true;
        base.Toes = 4;
        }

        public bool Nocturnal
        {
            set
            {
                nocturnal = value;
            }

        }

        public string Food
        {
            set
            {
                food = value;
            }

        }

    }
}
