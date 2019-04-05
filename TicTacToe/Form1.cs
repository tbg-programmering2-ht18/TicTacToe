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
    public partial class Form1 : Form
    {
        bool turn = true;
        int turnCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Adam", "Yeet");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turnCount++;
            DidIWin();
        }
        private void DidIWin()
        {
            bool IDidWin = false;
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                IDidWin = true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                IDidWin = true;
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                IDidWin = true;
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text))
                IDidWin = true;
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text))
                IDidWin = true;
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text))
                IDidWin = true;
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text))
                IDidWin = true;
            if ((C1.Text == B2.Text) && (B2.Text == A3.Text))
                IDidWin = true;

            if (IDidWin)
            {
                DisableButtons();
                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                MessageBox.Show(winner + " wins!", "Yes Yes Yes Yes");
            }
            else
            {
                if (turnCount == 9)
                    MessageBox.Show("Draw!", "No No No No!");
            }
        }
        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void DisableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            } catch { }
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("By Adam", "Yeet");
        }
    }
}
