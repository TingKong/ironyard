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
            //check if the position has an X or O in it
            //check winner
            //create a grid
            //ask player 2 to assign 0
            //check if the position has an X or O in it
            //check winner
            //loop until there is a winner
            //if there is no winner then it is a tie




            char cross = 'X';
            char circle = 'O';

            string[] myArray = new string[9];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i.ToString();

            }

            Grid(myArray);


            /***converting input into the location***/
            FirstPlayer(myArray, cross);

            Console.WriteLine("Player 2 Select a number");
            string player2 = Console.ReadLine();
            int b;
            Int32.TryParse(player2, out b);

            myArray[b] = circle.ToString();
            Grid(myArray);


            /***check for a winner***/
            while (myArray[0] == myArray[1] && myArray[1] == myArray[2])
            {
                Console.WriteLine("You Won");

            }



            Console.ReadLine();

        }
        static void Grid(string[] myArray)
        {
            Console.WriteLine(string.Format(" {0} | {1} | {2} ", myArray[0], myArray[1], myArray[2]));
            Console.WriteLine("____________");
            Console.WriteLine(string.Format(" {0} | {1} | {2} ", myArray[3], myArray[4], myArray[5]));
            Console.WriteLine("____________");
            Console.WriteLine(string.Format(" {0} | {1} | {2} ", myArray[6], myArray[7], myArray[8]));

        }

        static void FirstPlayer(string[] myArray2, char smiles)
        {
            Console.WriteLine("Player 1 Select a number");
            string player1 = Console.ReadLine();
            int a;
            Int32.TryParse(player1, out a);

            myArray2[a] = smiles.ToString();
            Grid(myArray2);

        }


    }
}
