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
    public partial class Form2 : Form
    {
        public string winner;
        private Form1 Board;
        public Form2(Form1 b)

        {
            Board = b;
            InitializeComponent();
        }

        private void showWinner(object sender, EventArgs e)
        {
           
            WinnerLabel.Text = "Wygrywa:" + winner;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Board.clearBoard();
            this.Close();
        }
    }
}
