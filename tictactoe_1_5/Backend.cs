using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///  Joe Slaugh, Joe Lambert, Tanner Woodrum, Chris Isaksen
/// </summary>
namespace tictactoe_1_5
{
    class Backend
    {
        public void DisplayBoard(char[] array)
        {
            //This function displays the board :)
            Console.WriteLine(array[0] + "|" + array[1] + "|" + array[2]);
            Console.WriteLine("_____");
            Console.WriteLine(array[3] + "|" + array[4] + "|" + array[5]);
            Console.WriteLine("_____");
            Console.WriteLine(array[6] + "|" + array[7] + "|" + array[8]);

        }
        public string TestWin(char[] array)
        {
            //This function is to test the win :)
            if (array[0] == array[3] && array[3] == array[6])
            {
                if (array[0] == 'O')
                {
                    return "Player 1 wins!";
                }
                else
                {
                    return "Player 2 Wins!";
                }
    
            }
            else if (array[0] == array[1] && array[1] == array[2])
            {
                if (array[0] == 'O')
                {
                    return "Player 1 wins!";
                }
                else
                {
                    return "Player 2 Wins!";
                }
            }
            else if (array[0] == array[4] && array[4] == array[8])
            {
                if (array[0] == 'O')
                {
                    return "Player 1 wins!";
                }
                else
                {
                    return "Player 2 Wins!";
                }
            }
            else if (array[1] == array[4] && array[4] == array[7])
            {
                if (array[1] == 'O')
                {
                    return "Player 1 wins!";
                }
                else
                {
                    return "Player 2 Wins!";
                }
            }
            else if (array[3] == array[4] && array[4] == array[5])
            {
                if (array[3] == 'O')
                {
                    return "Player 1 wins!";
                }
                else
                {
                    return "Player 2 Wins!";
                }
            }
            else if (array[6] == array[4] && array[4] == array[2])
            {
                if (array[6] == 'O')
                {
                    return "Player 1 wins!";
                }
                else
                {
                    return "Player 2 Wins!";
                }
            }
            else if (array[2] == array[5] && array[5] == array[8])
            {
                if (array[2] == 'O')
                {
                    return "Player 1 wins!";
                }
                else
                {
                    return "Player 2 Wins!";
                }
            }
            else if (array[6] == array[7] && array[7] == array[8])
            {
                if (array[6] == 'O')
                {
                    return "Player 1 wins!";
                }
                else
                {
                    return "Player 2 Wins!";
                }
            }
            // If the game has lasted it's full length and no one has won report a tie
            else if (array[9] == 'T')
            {
                return "It's a Draw";
            }

            // report nothing if there is no winner or loser
            return "";
        }
    }
}
