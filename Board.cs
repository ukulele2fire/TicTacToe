using System;

namespace TicTacToe
{
    //game board
    public class Board
    {
        private string[,] board;

        public Board()
        {
            board = new string[3, 3];
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    board[r, c] = "";
                }
            }
        }

        public void setSquare(int row, int col, String sym)
        {
            board[row, col] = sym;
        }

        public string getSquare(int row, int col)
        {
            return board[row, col];
        }

        public bool isClear(int row, int col)
        {
            return equals(row, col, "");
        }

        public bool equals(int row, int col, String sym)
        {
            return String.Equals(board[row, col], sym);
        }

        public void displayBoard()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(board[r, c] + ", ");
                }
                Console.WriteLine();
            }
        }

        public bool isWinner(String sym)
        {
            return checkRows(sym) || checkColumns(sym) || checkDiagonals(sym);
        }

        private bool checkRows(String sym)
        {
            for (int r = 0; r < 3; r++)
            {
                int count = 0;
                for (int c = 0; c < 3; c++)
                {
                    if (String.Equals(board[r, c], sym))
                        count++;
                }
                if (count == 3)
                    return true;
            }
            return false;
        }

        private bool checkColumns(String sym)
        {
            for (int c = 0; c < 3; c++)
            {
                int count = 0;
                for (int r = 0; r < 3; r++)
                {
                    if (String.Equals(board[r, c], sym))
                        count++;
                }
                if (count == 3)
                    return true;
            }
            return false;
        }

        private bool checkDiagonals(String sym)
        {
            //top-to-bottom diagonal
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                if (String.Equals(board[i, i], sym))
                    count++;
            }
            if (count == 3)
                return true;

            //bottom-to-top diagonal
            count = 0;
            for (int i = 0; i < 3; i++)
            {
                if (String.Equals(board[2 - i, i], sym))
                    count++;
            }
            if (count == 3)
                return true;

            return false;
        }

        public bool isDraw()
        {
            int count = 0;
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (board[r, c].Length == 1)
                        count++;
                }
            }
            return count == 9;
        }
    }
}

