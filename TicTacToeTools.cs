using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class TicTacToeTools
    {
        public void PrintBoard(int[,] boardArray)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int y = 0; y < 3; y++)
                {
                    char mark = ' ';

                    if (boardArray[i, y] == 0)
                    {
                        mark = '_';
                    }
                    else if (boardArray[i, y] == 1)
                    {
                        mark = 'X';
                    }
                    else if (boardArray[i, y] == 2)
                    {
                        mark = 'O';
                    }

                    Console.Write(mark + " ");
                }
                Console.WriteLine();
            }
        }


        public int EvalutateWin(int[,] boardArray)
        {
            int result = 0;
            // Check rows, columns, and diagonals for a winner
            for (int i = 0; i < 3; i++)
            {
                if (boardArray[i, 0] == 1 && boardArray[i, 1] == 1 && boardArray[i, 2] == 1)
                    result = 1; // Player X wins in a row
                if (boardArray[i, 0] == 2 && boardArray[i, 1] == 2 && boardArray[i, 2] == 2)
                    result = 2; // Player O wins in a row
                if (boardArray[0, i] == 1 && boardArray[1, i] == 1 && boardArray[2, i] == 1)
                    result = 1; // Player X wins in a column
                if (boardArray[0, i] == 2 && boardArray[1, i] == 2 && boardArray[2, i] == 2)
                    result = 2; // Player O wins in a column
            }
            if (boardArray[0, 0] == 1 && boardArray[1, 1] == 1 && boardArray[2, 2] == 1)
                result = 1; // Player X wins diagonally
            if (boardArray[0, 0] == 2 && boardArray[1, 1] == 2 && boardArray[2, 2] == 2)
                result = 2; // Player O wins diagonally
            if (boardArray[0, 2] == 1 && boardArray[1, 1] == 1 && boardArray[2, 0] == 1)
                result = 1; // Player X wins diagonally
            if (boardArray[0, 2] == 2 && boardArray[1, 1] == 2 && boardArray[2, 0] == 2)
                result = 2; // Player O wins diagonally

            return result;
        }
    }
}
