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

            int[] numarray = new int[100];
            for (int i = 0; i < numarray.Length; ++i)
            {
               numarray[i] = i + 1;

                if (numarray[i] % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
               else if (numarray[i] % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else (numarray[i] % 3 == 0 && numarray[i] % 5 == 0)
                {
                    Console.WriteLine("FuzzBuzz");
                }

                Console.WriteLine(numarray[i]);

            }

           

            Console.Read();

        }
    }
}
