using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class TicTacToeTools
    {
        public string PrintBoard(boardArray)
        {
            string result = "";
            
            for(int i=0; i < 3; i++)
            {
                for(int y=0;  < 3; i++)
                {
                    char mark = "";

                    if (boardArray[i][y] == 0)
                    {
                        mark = " ";
                    }
                    else if (boardArray[i][y] == 1)
                    {
                        mark = "X";
                    }
                    else if (boardArray[i][y] == 2)
                    {
                        mark = "O";
                    }

                    Console.Write(mark + " ");
                }
                Console.WriteLine();
            }



        }

        pubic int evalutateWin(int[,] boardArray)
        {
            // Check rows, columns, and diagonals for a winner
            for (int i = 0; i < 3; i++)
            {
                string result = 0;

                if (board[i, 0] == ‘1’ && board[i, 1] == ‘1’ && board[i, 2] == ‘1’)
                    result = 1; // Player X wins in a row
                if (board[i, 0] == ‘2’ && board[i, 1] == ‘2’ && board[i, 2] == ‘2’)
                    result = 2; // Player O wins in a row
                if (board[0, i] == ‘1’ && board[1, i] == ‘1’ && board[2, i] == ‘1’)
                    result = 1; // Player X wins in a column
                if (board[0, i] == ‘2’ && board[1, i] == ‘2’ && board[2, i] == ‘2’)
                    result = 2; // Player O wins in a column
            }
            if (board[0, 0] == ‘1’ && board[1, 1] == ‘1’ && board[2, 2] == ‘1’)
                result = 1; // Player X wins diagonally
            if (board[0, 0] == ‘2’ && board[1, 1] == ‘2’ && board[2, 2] == ‘2’)
                result = 2; // Player O wins diagonally
            if (board[0, 2] == ‘1’ && board[1, 1] == ‘1’ && board[2, 0] == ‘1’)
                result = 1; // Player X wins diagonally
            if (board[0, 2] == ‘2’ && board[1, 1] == ‘2’ && board[2, 0] == ‘2’)
                result = 2; // Player O wins diagonally

            return result;
        }
}
    }
}
