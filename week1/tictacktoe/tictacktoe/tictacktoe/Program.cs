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
            //check if they entered a number 1-9
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
            bool myBool;
            bool myBool2;


            string[] myArray = new string[9];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i.ToString();

            }

            Grid(myArray);


         
            do
            {
                FirstPlayer(myArray, cross);
                myBool = checker(myArray, cross);
                if (myBool == false)
                {
                    break;
                }
                myBool2 = tied(myArray);
                if (myBool2)
                {
                    break;
                }
                SecondPlayer(myArray, circle);
                myBool = checker(myArray, cross);
                if (myBool == false)
                {
                    break;
                }
                myBool2 = tied(myArray);
                if (myBool2)
                {
                    break;
                }


            }
            while (myBool);






            Console.ReadLine();

        }
        /***grid***/

        static void Grid(string[] myArray)
        {
            Console.WriteLine("");
            Console.WriteLine(string.Format(" {0} | {1} | {2} ", myArray[0], myArray[1], myArray[2]));
            Console.WriteLine("____________");
            Console.WriteLine(string.Format(" {0} | {1} | {2} ", myArray[3], myArray[4], myArray[5]));
            Console.WriteLine("____________");
            Console.WriteLine(string.Format(" {0} | {1} | {2} ", myArray[6], myArray[7], myArray[8]));
            Console.WriteLine("");

        }
        /***converting input into the location***/

        static void FirstPlayer(string[] myArray2, char gamepiece)
        {
            Console.WriteLine("Player 1 Select a number");
            string player1 = Console.ReadLine();

            if (player1 == "O")
            {

                Console.WriteLine("This spot is already taken, please pick another spot");
            }

            int a;
            Int32.TryParse(player1, out a);

            

            while (a > 8)

            {
                Console.WriteLine("The number you selected must be less than 8");
                Console.WriteLine("Player 1 Select a number");
                player1 = Console.ReadLine();

                Int32.TryParse(player1, out a);





            } while (a < 0)
            {
                Console.WriteLine("The number you selected must be greater than 0");
                Console.WriteLine("Player 1 Select a number");
                player1 = Console.ReadLine();

                Int32.TryParse(player1, out a);



            }
          

            myArray2[a] = gamepiece.ToString();
            Grid(myArray2);


        }
        /***converting input into the location***/

        static void SecondPlayer(string[] myArray3, char gamepiece2)
        {

            Console.WriteLine("Player 2 Select a number");
            string player2 = Console.ReadLine();
            //if (player2 == myArray3[i] && )
            //{

            //    Console.WriteLine("This spot is already taken, please pick another spot");
            //    player2 = Console.ReadLine();
            //}

            int b;
            Int32.TryParse(player2, out b);


          
            while (b > 8)

            {
                Console.WriteLine("The number you selected must be less than 8");
                Console.WriteLine("Player 2 Select a number");
                player2 = Console.ReadLine();

                Int32.TryParse(player2, out b);





            } while (b < 0)
            {
                Console.WriteLine("The number you selected must be greater than 0");
                Console.WriteLine("Player 2 Select a number");
                player2 = Console.ReadLine();

                Int32.TryParse(player2, out b);



            }
            


            myArray3[b] = gamepiece2.ToString();
            Grid(myArray3);



        }

        /***check for a winner***/
        static bool checker(string[] myArray4, char gamepiece3)
        {

            if (myArray4[0] == myArray4[1] && myArray4[1] == myArray4[2])
            {
                if (myArray4[0] == gamepiece3.ToString())
                {
                    Console.WriteLine("Player 1 you won!");

                }
                else
                {
                    Console.WriteLine("Player 2 you won!");

                }

                return false;

            }
            else if (myArray4[3] == myArray4[4] && myArray4[4] == myArray4[5])
            {
                if (myArray4[3] == gamepiece3.ToString())
                {
                    Console.WriteLine("Player 1 you won!");
                }
                else
                {
                    Console.WriteLine("Player 2 you won!");

                }
                return false;
            }
            else if (myArray4[6] == myArray4[7] && myArray4[7] == myArray4[8])
            {
                if (myArray4[6] == gamepiece3.ToString())
                {
                    Console.WriteLine("Player 1 you won!");
                }
                else
                {
                    Console.WriteLine("Player 2 you won!");

                }
                return false;
            }
            else if (myArray4[0] == myArray4[3] && myArray4[3] == myArray4[6])
            {
                if (myArray4[0] == gamepiece3.ToString())
                {
                    Console.WriteLine("Player 1 you won!");
                }
                else
                {
                    Console.WriteLine("Player 2 you won!");

                }
                return false;
            }
            else if (myArray4[1] == myArray4[4] && myArray4[4] == myArray4[7])
            {
                if (myArray4[7] == gamepiece3.ToString())
                {
                    Console.WriteLine("Player 1 you won!");
                }
                else
                {
                    Console.WriteLine("Player 2 you won!");

                }
                return false;
            }
            else if (myArray4[2] == myArray4[5] && myArray4[5] == myArray4[8])
            {
                if (myArray4[8] == gamepiece3.ToString())
                {
                    Console.WriteLine("Player 1 you won!");
                }
                else
                {
                    Console.WriteLine("Player 2 you won!");

                }
                return false;
            }
            else if (myArray4[0] == myArray4[4] && myArray4[4] == myArray4[8])
            {
                if (myArray4[8] == gamepiece3.ToString())
                {
                    Console.WriteLine("Player 1 you won!");
                }
                else
                {
                    Console.WriteLine("Player 2 you won!");

                }
                return false;
            }
            else if (myArray4[2] == myArray4[4] && myArray4[4] == myArray4[6])
            {
                if (myArray4[6] == gamepiece3.ToString())
                {
                    Console.WriteLine("Player 1 you won!");
                }
                else
                {
                    Console.WriteLine("Player 2 you won!");

                }

                return false;
            }


            return true;
        }

        static bool tied(string[] myArray5)
        {

       
                for (int i = 0; i < myArray5.Length; i++)
                {
                  if(myArray5[i] != "X" && myArray5[i] != "O")
                    {
                   
                        return false;
                    }
                 
                   
                }


            Console.WriteLine("You have a tie!");
            return true;

        }

       
    }
}
