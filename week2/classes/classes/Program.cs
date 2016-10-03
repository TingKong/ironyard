using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Ocean myOcean = new Ocean(5);
            myOcean.Megalodons = true;
            Ocean myNemo = new Ocean("Bubbles");

            Ocean newOcean = new Ocean("bloat");
            newOcean.Megalodons = false;
            Console.WriteLine(myOcean.Megalodons);
            Console.WriteLine(newOcean.Megalodons);

            Land tingLand = new Land(1000000000);
            Land landName = new Land("Fluffy");

            Sky tingSky = new Sky(3);
            Sky tingSky2 = new Sky(100, 5);



            Console.Read();
        }
    }
}
