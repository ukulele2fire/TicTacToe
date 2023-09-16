using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class GameForm : Form
    {
        
        private Board board;
        private AI cpu;
        private Button[,] allButtons;
        private DifficultyForm diffForm;
        public GameForm()
        {
            InitializeComponent();
            board = new Board();
            cpu = new AI("Normal");
            allButtons = new Button[,] { { button1, button2, button3 }, { button4,button5,button6},
                                           { button7,button8,button9 }};
            diffForm = new DifficultyForm();
            disableButtons();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            string tag = btn.Tag.ToString();
            int row = Int32.Parse(tag.Substring(0, 1));
            int col = Int32.Parse(tag.Substring(2));

            bool playerWon = false;
            bool cpuWon = false;

            if (board.isClear(row,col))
            {
                btn.Text = "O";
                board.setSquare(row, col, "O");
                playerWon = board.isWinner("O");
                if (!playerWon)
                {
                    cpu.updateSimulation(board);
                    cpu.move(board);
                    allButtons[cpu.row, cpu.col].Text = "X";
                    cpuWon = board.isWinner("X");
                }
            }

            if (playerWon || cpuWon || board.isDraw())
            {
                disableButtons();
                newGameBtn.Enabled = true;
                difficultyBtn.Enabled = true;
                if (playerWon)
                {
                    resultLabel.Text = "You Won!";
                    resultLabel.ForeColor = Color.LawnGreen;
                }
                else if (cpuWon)
                {
                    resultLabel.Text = "You Lost!";
                    resultLabel.ForeColor = Color.Red;
                }
                else if (board.isDraw())
                {
                    resultLabel.Text = "Draw!";
                    resultLabel.ForeColor = Color.DarkSalmon;
                }
                   
            }
    
        }

        private void disableButtons()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    allButtons[r, c].Enabled = false;
                }
            }
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    allButtons[r, c].Enabled = true;
                    allButtons[r, c].Text = "";
                }
            }
            cpu = new AI(diffForm.difficulty);
            board = new Board();
            cpu.updateSimulation(board);
            resultLabel.Text = "";
            newGameBtn.Enabled = false;
            difficultyBtn.Enabled = false;
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void difficultyBtn_Click(object sender, EventArgs e)
        {
            diffForm.ShowDialog();
        }
    }
}

    
