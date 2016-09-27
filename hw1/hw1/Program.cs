using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myHello = "Hello World";
            int myNumber = 1492;
            bool doIHaveADog = true;
            string dogState = "It is";
            string dogState2 = "that I have a dog at home";
            DateTime myDate = DateTime.Today;
            double dollerAmount = 5.45;
            char symbol = ('X');

            Console.WriteLine(myHello);
            Console.WriteLine("Columbus Sailed the world in " + myNumber);
            Console.WriteLine(dogState + " " + doIHaveADog.ToString().ToLower() + " " + dogState2);
            Console.WriteLine("Today is " + myDate.ToString("d"));
            Console.WriteLine("I spent " + dollerAmount.ToString("C") + " on a cheeseburger");
            Console.WriteLine(symbol + " marks the spot");

            //ADVENTURER MODE

            String[] favMovies = new string[] { "The Holiday", "The Switch", "Nemo", "Wall-E" };
            var ting = new [] { "women", "asian", "foodie", "animal lover"};

            for (int i = 0; i < favMovies.Length; i++)
            {
                
                string s = favMovies[i];
              
                if (i == favMovies.Length - 1)

                {
                    Console.Write(s);
                }
                else
                {
                    Console.Write(s + ", ");

                }




            }

            Console.WriteLine();
            for (int i = 0; i < ting.Length; i++)
            {

                string j = ting[i];
                Console.WriteLine(j + ", ");
               

            }

            //EPIC
            dynamic mymoviearray = new[]
          {
               new { title = "The Holiday", genre = "romantic comedy", rating = "10"},
                 new { title = "The Switch", genre = "romantic comedy", rating = "8"},
               new { title = "Nemo", genre = "animation", rating = "9"},
                              new { title = "Wall-E", genre = "animation", rating = "10"},

              };

            Console.WriteLine("I love this movie called " + mymoviearray[0].title + ", it is a " + mymoviearray[0].genre + " I give it a rating of " + mymoviearray[0].rating + ".") ;
            Console.WriteLine("I love this movie called " + mymoviearray[1].title + ", it is a " + mymoviearray[1].genre + " I give it a rating of " + mymoviearray[1].rating + ".") ;
            Console.WriteLine("I love this movie called " + mymoviearray[2].title + ", it is a " + mymoviearray[2].genre + " I give it a rating of " + mymoviearray[2].rating + ".");
            Console.WriteLine("I love this movie called " + mymoviearray[3].title + ", it is a " + mymoviearray[3].genre + " I give it a rating of " + mymoviearray[3].rating + ".") ;


            Console.ReadLine();
        }
    }
}
