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
    enum CurrentPlayer
    {
        Cross,
        Circle

    }
    public partial class Form1 : Form
    {
        private const string V = "X";
        CurrentPlayer currentPlayer;
        public Form1()
        {
            InitializeComponent();
            currentPlayer = CurrentPlayer.Cross;
            

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mark(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if (currentPlayer == CurrentPlayer.Cross)
            {
                senderButton.Text = "x";
                currentPlayer = CurrentPlayer.Circle;
            }
            else
            {
                senderButton.Text = "o";
                currentPlayer = CurrentPlayer.Cross;
            }
            changeLabel();
            checkForWinner();
            checkForWinner2();

            //Form2 victoryscreen = new Form2();
            //victoryscreen.Show();
        }

        internal void clearBoard()
        {
            throw new NotImplementedException();
        }

        public void changeLabel()
        {
            if (currentPlayer == CurrentPlayer.Cross)
            {
                currentPlayerLabel.Text = "krzyżyk";
            }
            else
            {
                currentPlayerLabel.Text = "kółko";
            }

        }
        public void checkForWinner()
        {
            if ( TL.Text == "x" && CL.Text == "x" && BL.Text == "x"
                || TC.Text == "x" && CC.Text == "x" && BC.Text == "x"
                || TR.Text == "x" && CR.Text == "x" && BR.Text == "x"
                || CL.Text == "x" && CC.Text == "x" && CR.Text == "x"
                || TL.Text == "x" && TC.Text == "x" && TR.Text == "x"
                || BL.Text == "x" && BC.Text == "x" && BR.Text == "x"

                ||BL.Text == "x" && CC.Text == "x" && TR.Text == "x"

                ||BR.Text == "x" && CC.Text == "x" && TL.Text == "x")
            {
                Form2 victoryscreen = new Form2(this);
                victoryscreen.winner = TL.Text;
                victoryscreen.Show();
            }
        }
        public void checkForWinner2()
        {
            if (TL.Text == "o" && CL.Text == "o" && BL.Text == "o"
                  || TC.Text == "o" && CC.Text == "o" && BC.Text == "o"
                  || TR.Text == "o" && CR.Text == "o" && BR.Text == "o"
                  || CL.Text == "o" && CC.Text == "o" && CR.Text == "o"
                  || TL.Text == "o" && TC.Text == "o" && TR.Text == "o"
                  || BL.Text == "o" && BC.Text == "o" && BR.Text == "o"

                  || BL.Text == "o" && CC.Text == "o" && TR.Text == "o"

                  || BR.Text == "o" && CC.Text == "o" && TL.Text == "o")
            {
                Form2 victoryscreen = new Form2(this);
                victoryscreen.winner = TL.Text;
                victoryscreen.Show();
            }
        }

    public void clearbound()
        {
            TableLayoutControlCollection buttons = tableLayoutPanel1.Controls;

            for(int i=0; i < buttons.Count; i++)
            {
                if (buttons[i] is Button)
                    buttons[i].Text = "";
            }
            currentPlayer = CurrentPlayer.Cross;
        }

    }
}











