using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerkayGürbüz_MidTermExam_TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int turn = 1;   //know the who turns
        int scoreX = 0;
        int scoreO = 0;
        int lastWinner = 0;
        void checkwinner(string symbol)
        {
            if(button1.Text==symbol && button2.Text==symbol && button3.Text==symbol || button4.Text==symbol && button5.Text==symbol && button6.Text==symbol
                || button7.Text==symbol && button8.Text==symbol && button9.Text==symbol || button1.Text==symbol && button5.Text==symbol && button9.Text==symbol 
                || button3.Text==symbol && button5.Text==symbol && button7.Text==symbol || button1.Text==symbol && button4.Text==symbol && button7.Text==symbol
                || button2.Text == symbol && button5.Text == symbol && button8.Text == symbol || button3.Text == symbol && button6.Text == symbol && button9.Text == symbol)
            {
                btnTurn.Text = symbol+ " is Won";

                if (symbol == "X")
                {
                    scoreX++;
                    lastWinner = 1;
                }
                else
                {
                    scoreO++;
                    lastWinner = 0;
                }

                lblScoreX.Text = "" + scoreX;
                lblScoreO.Text = "" + scoreO;




                //If game finished, user can not press the buttons.
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                btnPlay.Visible = true;
            }
            //check if the game is draw 
            else if(button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                btnTurn.Text = "DRAW!";

                turn = 1;
                //If game finished, user can not press the buttons.
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                btnPlay.Visible = true;
            }



        }

        void addSymbol(object senderobj)
        {
            string buttonTxt = ((Button)senderobj).Text;
            if (buttonTxt == "")
            {
                if (turn == 0)    //0 means O turns
                {
                    ((Button)senderobj).Text = "O";
                    
                    turn = 1;
                    btnTurn.Text = "Turn is X";
                    checkwinner("O");

                }
                else
                {
                    ((Button)senderobj).Text = "X";
                    
                    turn = 0;
                    btnTurn.Text = "Turn is O";
                    checkwinner("X");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPlay.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addSymbol(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addSymbol(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addSymbol(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addSymbol(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addSymbol(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addSymbol(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addSymbol(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addSymbol(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addSymbol(sender);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            btnPlay.Visible = false;

            //clean the buttons
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            //check the last winner
            if (lastWinner == 0)
            {
                turn = 0;
                btnTurn.Text = "Turn is O";
            }
            else
            {
                turn = 1;
                btnTurn.Text = "Turn is X";
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
