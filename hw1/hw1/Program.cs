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
            string symbol = "X";

            Console.WriteLine(myHello);
            Console.WriteLine("Columbus Sailed the world in " + myNumber);
            Console.WriteLine(dogState + " " + doIHaveADog.ToString().ToLower() + " " + dogState2);
            Console.WriteLine("Today is " + myDate.ToString("d"));
            Console.WriteLine("I spent " + dollerAmount.ToString("C") + " on a cheeseburger");
            Console.WriteLine(symbol + " marks the spot");




            Console.ReadLine();
        }
    }
}
