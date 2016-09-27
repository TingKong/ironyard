using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz_exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //ANSWER IN ARRAY
            //for (int i = 0; i < 100; ++i)
            //{
            //    if (i <= 0)
            //    {
            //        Console.WriteLine("0");
            //    }
            //    else if (i % 5 == 0 && i % 3 == 0)
            //    {
            //        Console.WriteLine("FuzzBuzz");
            //    }

            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }

            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //ANSWER IN INPUT

            //take input
            //spit up number up to the input
            //if divisible by 3 = Fizz
            //if divisible by 5 = Buzz
            //if divisible by both = FizzBuzz


            string y;

            Console.WriteLine("How high do you want to go?");

            y = Console.ReadLine();
            int newNum;
            if (!Int32.TryParse(y, out newNum))
            {
                Console.WriteLine("you didn't enter a number");

            }
            else
            {
                for (int i = newNum; i > 0; i--)
                {
                    if (i <= 0)
                    {
                        Console.WriteLine("0");
                    }
                    else if (i % 5 == 0 && i % 3 == 0)
                    {
                        Console.WriteLine("FuzzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }

                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            //for (int i = 0; i < newNum; ++i)
            //{
            //    if (i <= 0)
            //    {
            //        Console.WriteLine("0");
            //    }
            //    else if (i % 5 == 0 && i % 3 == 0)
            //    {
            //        Console.WriteLine("FuzzBuzz");
            //    }

            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }

            //    else
            //    {
            //        Console.WriteLine(i);
            //    }



            Console.Read();

        }
    }
}


