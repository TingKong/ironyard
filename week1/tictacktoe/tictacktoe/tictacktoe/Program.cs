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


            
         
            char player1 = 'X';
            char player2 = 'O';

            int[] myArray = new int[9];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;

            }

            WriteGridLine1(string.Format(" {0} | {1} | {2} ", i, i, i));
            Console.WriteLine("____________");
            WriteGridLine1(string.Format(" {0} | {1} | {2} ", i, i, i));
            Console.WriteLine("____________");
            WriteGridLine1(string.Format(" {0} | {1} | {2} ", i, i, i));




          



            Console.ReadLine();



        }
        static string WriteGridLine1(string lines)
        {
            Console.WriteLine(lines);
            return lines;
           
        }


    }
}
