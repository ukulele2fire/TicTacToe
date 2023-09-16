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
    public partial class DifficultyForm : Form
    {
        public String difficulty { get; private set; }
        public DifficultyForm()
        {
            InitializeComponent();
            difficulty = "Normal";
        }

        private void easyBtn_Click(object sender, EventArgs e)
        {
            difficulty = "Easy";
            this.Close();
        }

        private void normalBtn_Click(object sender, EventArgs e)
        {
            difficulty = "Normal";
            this.Close();
        }

        private void impossibleBtn_Click(object sender, EventArgs e)
        {
            difficulty = "Impossible";
            this.Close();
        }
    }
}
