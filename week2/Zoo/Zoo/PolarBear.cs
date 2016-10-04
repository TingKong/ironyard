using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class PolarBear : Mammals
    { 
     private int weight;
     private bool coldClimates = true;

    public PolarBear()
    {
        base.MeatEaters = true;
        base.Furry = true;
    }
    public int Weight
    {
            get
            {
                return weight;
            }
        set
        {
            weight = value;
        }
    }

    public bool ColdClimates
    {
            get
            {
                return coldClimates;
            }
           
    }

}
}
