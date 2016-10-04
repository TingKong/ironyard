using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Key Facts on the animals at Ting's Zoo"  );
            Console.WriteLine("");

            PolarBear myMam = new PolarBear();
            Console.WriteLine("Polar Bears have " + myMam.NumOfLegs + "legs" + "and they typically live on " + myMam.Location );



            Console.ReadLine();

        }
    }
}
