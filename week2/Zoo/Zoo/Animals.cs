using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Animals
    {
        private string location;
        private int numOfLegs;

        public int NumOfLegs
        {
            get
            {
                return numOfLegs;
            }

            set
            {
                numOfLegs = value;
            }
        }

        public string Location
        {
          

            set
            {
                location = value;
            }
        }
    }
}
