using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictacktoe
{
    class Program
    {
        private static object i;

        static void Main(string[] args)
        {
            //create a grid
            //assign player 1 - 0
            //assign player 2 - X
            //ask player 1 to assign X to a place
            //check if the position is placed
            //check winner
            //create a grid
            //ask player 2 to assign 0
            //check for a winner
            //loop until there is a winner
            //if there is no winner then it is a tie


            
         
            char cross = 'X';
            char circle = 'O';

            int[] myArray = new int[9];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;

            }

            Grid( myArray);


/***converting input into the location***/
            Console.WriteLine("Select a number");
            string player1 = Console.ReadLine();

            if (player1 == "1")
            {
                int a = 1;
                Int32.TryParse(player1, out a);
                myArray[1] == cross;

            }



            Console.ReadLine();

        }
        static void Grid(int[] myArray)
        {
            Console.WriteLine(string.Format(" {0} | {1} | {2} ", myArray[0], myArray[1], myArray[2]));
            Console.WriteLine("____________");
            Console.WriteLine(string.Format(" {0} | {1} | {2} ", myArray[3], myArray[4], myArray[5]));
            Console.WriteLine("____________");
            Console.WriteLine(string.Format(" {0} | {1} | {2} ", myArray[6], myArray[7], myArray[8]));

        }


    }
}
