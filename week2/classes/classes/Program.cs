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
            Ocean myOcean = new Ocean(5, 20);
            myOcean.Megalodons = true;
            myOcean.SinkenShips = true;
            Ocean myNemo = new Ocean("Bubbles");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("/********OCEAN********/");
            Console.WriteLine("There are " + myOcean.WarShips + " haunted ghost ships living at the bottom of my ocean. " + "\n" + "While you are swimming, becareful with our giant octopuses, there are " + myOcean.GiantOctopus + " of them hungry and lurking");
            Console.WriteLine("Are megalodons real? " + myOcean.Megalodons);
            Console.WriteLine("Is the sinken Titanic in my ocean? " + myOcean.SinkenShips);
            Console.WriteLine("My favorite character in the movie Nemo is " + myNemo.Nemo + "!!!!!!");
            Console.WriteLine();
            Console.WriteLine();

            //Console.WriteLine(newOcean.Megalodons);

            Land tingLand = new Land(1000000000 , 36);
            Land landName = new Land("Fluffy");

            Console.WriteLine("/********LAND********/");
            Console.WriteLine("Is there only one Disney World in the USA? "  + tingLand.DisneyWorld);
            Console.WriteLine("Do humans live on land? " + tingLand.Humans);
            Console.WriteLine("We will be building " + tingLand.SpaceStations + " space stations in the year 2030");
            Console.WriteLine("There are secretly " + tingLand.Godzilla + " Godzilla roaming around earth.");
            Console.WriteLine("The Godzilla living in my backyard is called " + landName.NameGodzilla + ".");
            Console.WriteLine();
            Console.WriteLine();


            Sky tingSky = new Sky(2000);
            Sky tingSky2 = new Sky(100, 5);

            Console.WriteLine("/********SKY********/");
            Console.WriteLine("There are currently " + tingSky.FlyingNakedHumans + " naked people flying and on the loose in the sky.");
            Console.WriteLine("There are " + tingSky2.Airplanes + " airplanes in service which is a lot more than our " + tingSky2.FlyingCars + " flying cars.");
            Console.WriteLine("Do you believe in Aliens?  " + tingSky.Aliens);
            Console.WriteLine("Does Zeus live in the clouds? " + tingSky.Clouds);





            Console.Read();
        }
    }
}
