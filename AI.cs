using System;
using System.Windows.Forms;

namespace TicTacToe
{
    //computer opponent
    public class AI
    {
        private Board simulatedBoard;
        public string difficulty { get; set; }
        private String symbol;

        //keep track of latest changes
        public int row { get; private set; }
        public int col { get; private set; }

        public AI(String diff)
        {
            simulatedBoard = new Board();
            difficulty = diff;
            symbol = "X";
            row = 0;
            col = 0;
        }

        //updates the simulated board
        public void updateSimulation(Board realBoard)
        {


            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    simulatedBoard.setSquare(r, c, realBoard.getSquare(r, c));
                }
            }
        }


        //computer makes a move
        public void move(Board realBoard)
        {
            Console.WriteLine("Real Board:");
            realBoard.displayBoard();

            Console.WriteLine("Simulated Board:");
            simulatedBoard.displayBoard();

            if (String.Equals(difficulty, "Easy"))
                easyMove(realBoard);
            else if (String.Equals(difficulty, "Normal"))
                normalMove(realBoard);
            else
                impossibleMove(realBoard);
 
        }

        public void easyMove(Board realBoard)
        {
            randomMove(realBoard);
        }

        public void normalMove(Board realBoard)
        {
            if (makeWin(realBoard))
                return;
            if (blockWin(realBoard))
                return;
            if (takeCenter(realBoard))
                return;
            else
                randomMove(realBoard);
        }

        public void impossibleMove(Board realBoard)
        {
            if (makeWin(realBoard))
                return;
            if (blockWin(realBoard))
                return;
            if (takeCenter(realBoard))
                return;
            if (blockDiagonalTrap(realBoard))
                return;
            if (randomCorner(realBoard))
                return;
            else
                randomMove(realBoard);
        }

        //returns true if makes winning move; false otherwise
        private bool makeWin(Board realBoard)
        {
            //loop through every square in the board
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    //if you can add the symbol to the square
                    if (realBoard.isClear(r,c))
                    {
                        simulatedBoard.setSquare(r, c, symbol);

                        //if result is a win, set the square on the real board
                        if (simulatedBoard.isWinner(symbol))
                        {
                            realBoard.setSquare(r, c, symbol);
                            row = r; col = c;
                            return true;
                        }
                        //otherwise, revert the change
                        else
                            simulatedBoard.setSquare(r, c, "");
                    }
                }
            }
            return false;
        }

        //returns true if blocks move; false otherwise
        private bool blockWin(Board realBoard)
        {
            //loop through every square in the board
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {

                    //if you can add the symbol to the square
                    if (realBoard.isClear(r,c))
                    {
                        simulatedBoard.setSquare(r, c, "O");

                        //if result is a win, set the square on the real board
                        if (simulatedBoard.isWinner("O"))
                        {
                            realBoard.setSquare(r, c, symbol);
                            row = r; col = c;
                            return true;
                        }
                        //otherwise, revert the change
                        else
                            simulatedBoard.setSquare(r, c, "");
                    }
                }
            }
            return false;
        }

        //takes center square if it is available
        public bool takeCenter(Board realBoard)
        {
            if (realBoard.isClear(1, 1))
            {
                realBoard.setSquare(1, 1, symbol);
                row = 1; col = 1;
                return true;
            }
            else
                return false;
        }

        public bool blockDiagonalTrap(Board realBoard)
        {
            bool isTrap = (realBoard.equals(0, 0, "O") && realBoard.equals(2, 2, "O"))
                          || (realBoard.equals(0, 2, "O") && realBoard.equals(2, 0, "O"));
            if (isTrap)
            {
                System.Random random = new System.Random();
                int randNum = random.Next(1, 5);
                
                switch (randNum)
                {
                    case 1:
                        realBoard.setSquare(0, 1, symbol);
                        row = 0; col = 1;
                        break;
                    case 2:
                        realBoard.setSquare(1, 0, symbol);
                        row = 1; col = 0;
                        break;
                    case 3:
                        realBoard.setSquare(1, 2, symbol);
                        row = 1; col = 2;
                        break;
                    case 4:
                        realBoard.setSquare(2, 1, symbol);
                        row = 2; col = 1;
                        break;
                }
                return true;
            }
            else
                return false;
        }

        public bool randomCorner(Board realBoard)
        {
            for (int r = 0; r < 3; r += 2)
            {
                for (int c = 0; c < 3; c += 2)
                {
                    if (realBoard.isClear(r, c))
                    {
                        realBoard.setSquare(r, c, symbol);
                        row = r; col = c;
                        return true;
                    }
                }
            }
            return false;
        }

        public void randomMove(Board realBoard)
        {
            if (realBoard.isDraw())
                return;

            System.Random random = new System.Random();
            int randRow = random.Next(0,3);
            int randCol = random.Next(0,3);

            while (!realBoard.isClear(randRow, randCol))
            {
                randRow = random.Next(0, 3);
                randCol = random.Next(0, 3);
            }

            realBoard.setSquare(randRow, randCol, symbol);
            row = randRow; col = randCol;
        }
    }

    
}