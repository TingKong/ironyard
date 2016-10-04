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
            myMam.Weight = 700;
            Console.WriteLine("At Ting's zoo our animals fall into 3 categories: mammals, birds, and fish.");
            Console.WriteLine("We have two types of mammals at Ting's Zoo. The Polar Bear and Koala Bear. ");
            Console.WriteLine("We have two types of birds at Ting's Zoo. The Owl and Ostrich. ");
            Console.WriteLine("We have two types of fish at Ting's Zoo. The Penguin and the Shark. ");

            Console.WriteLine("Polar Bears have " + myMam.NumOfLegs + " legs " + " and they typically live on " + myMam.Location.ToLower() +".");
            Console.WriteLine("It is " + myMam.MeatEaters.ToString().ToLower() + " that Polar Bears consume a lot of meat. Another " + myMam.Furry.ToString().ToLower() + " fact is that they are very furry.");
            Console.WriteLine("Polar Bears typically weigh about " + myMam.Weight + " pounds.");
            Console.WriteLine("Do Polar Bears live in the cold? " + myMam.ColdClimates + "!!");
            Console.WriteLine();

            Koala myMam2 = new Koala();
            myMam2.Hugs = "cuddle";
            myMam2.MeatEaters = false;
            myMam2.Trees = "they love to climb trees!";
            Console.WriteLine("Koala Bears are very similar to the Polar Bear. They too have " + myMam2.NumOfLegs + " legs and they also reside on " + myMam2.Location + ".");
            Console.WriteLine("Koala Bears are really friendly and they love to " + myMam2.Hugs + ".");
            Console.WriteLine("Koala Bears " + myMam2.Trees + ".");
            Console.WriteLine("Are Koala Bears Furry? " + myMam2.Furry + "!!!");
            Console.WriteLine("Do Koala's eat meet? " + myMam2.MeatEaters + " Unlike other mammals Koalas do not eat meat. ");
            Console.WriteLine();

            Owl myBird = new Owl();
            Console.WriteLine("The beautiful owl lives on" + myBird.Location + " and they have" + myBird.NumOfLegs + " legs.");
            Console.WriteLine("It is " + myBird.Nocturnal.ToString().ToLower());

            Ostrich myBird2 = new Ostrich();

            Penguins myFish = new Penguins();
            Sharks myFish2 = new Sharks();

            Console.ReadLine();

        }
    }
}
