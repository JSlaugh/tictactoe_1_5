using System;

namespace tictactoe_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!\n");
            // The chars will either be an O or an X
            // instanciating the array with gameboard positions
            // last position is used to test for a draw
            char[] gameBoard = new char[10] {'1','2','3','4','5','6','7','8','9',' '};

            //variables that hold the players' choice
            int p1; 
            int p2;

            //instanciate backend class
            Backend b = new Backend();

            //initial display of the board
            b.DisplayBoard(gameBoard);
            Console.WriteLine();

            //creating variables
            bool player1 = true;
            string response = "";
            string message = ", select a position on the board (type the corresponding number): ";

            //for loop that will go through the game with the user
            for (int i = 0; i< gameBoard.Length; i++)
            {
                // player 1 will be O's and player 2 will be X's

                if(player1)
                {
                    Console.Write($"Player 1{message}");

                    p1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    gameBoard[p1-1] = 'O';

                    // toggle the players
                    player1 =   false;
                    b.DisplayBoard(gameBoard);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write($"Player 2{message}");

                    p2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    gameBoard[p2-1] = 'X';

                    // toggle the players
                    player1 =   true;
                    b.DisplayBoard(gameBoard);
                    Console.WriteLine();
                }

                //if we have reached the max number of turns, then we will send in the position
                if  (i  ==  8) gameBoard[9] = 'T';

                //set response message to return of TestWin method
                response = b.TestWin(gameBoard);

                // if there is a response break out of for loop
                if(response.Length > 0) break;
            }

            // before we display the winner, we will display the board one last time
            b.DisplayBoard(gameBoard);
            Console.WriteLine();
            Console.WriteLine(response);
        }
    }
}
