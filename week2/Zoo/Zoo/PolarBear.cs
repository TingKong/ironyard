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
     private bool coldClimates;

    public PolarBear()
    {
        base.MeatEaters = true;
        base.Furry = true;
    }
    public int Weight
    {
        set
        {
            weight = value;
        }
    }

    public bool ColdClimates
    {
        set
        {
            coldClimates = value;
        }

    }

}
}
