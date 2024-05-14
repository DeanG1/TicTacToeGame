using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vesela_Apostolova_2101681070__Deyan_Guzelev_2101681075
{
    public partial class TTT : Form
    {
        public TTT()
        {
            InitializeComponent();
        }
        string[] gameBoard = new string[9];
        int currentTurn = 0;
        int player1score = 0;
        int player2score = 0;


        public String ReturnSymbol(int turn) 
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }
        public System.Drawing.Color determineColor(String symbol) 
        {
            if (symbol.Equals("O"))
            {
                return System.Drawing.Color.SkyBlue;
            }
            else if (symbol.Equals("X"))
            {
                return System.Drawing.Color.PaleGreen;
            }
            return System.Drawing.Color.White;
        }
        public void CheckForWinner()
        {
            for (int i = 0; i < 8; i++)
            {
                string combination = "";
                int one = 0, two = 0, three = 0;
                switch (i)
                {
                    case 0:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                        one = 0;
                        two = 4;
                        three = 8;
                        break;
                    case 1:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                        one = 2;
                        two = 4;
                        three = 6;
                        break;
                    case 2:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                        one = 0;
                        two = 1;
                        three = 2;
                        break;
                    case 3:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                        one = 3;
                        two = 4;
                        three = 5;

                        break;
                    case 4:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                        one = 6;
                        two = 7;
                        three = 8;

                        break;
                    case 5:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                        one = 0;
                        two = 3;
                        three = 6;

                        break;
                    case 6:
                        combination = gameBoard[1] + gameBoard[4] + gameBoard[7];
                        break;
                        one = 1;
                        two = 4;
                        three = 7;
                    case 7:
                        combination = gameBoard[2] + gameBoard[5] + gameBoard[8];
                        one = 2;
                        two = 5;
                        three = 8;
                        break;
                }
                if (combination.Equals("000"))
                {
                    changeColor(one);
                    changeColor(two);
                    changeColor(three);
                    MessageBox.Show("O has won the game!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    player2score ++;
                    labelPlayer2Score.Text = ($"Player 2 score: {player2score}");
                }
                else if (combination.Equals("XXX"))
                {
                    changeColor(one);
                    changeColor(two);
                    changeColor(three);
                    MessageBox.Show("X has won the game!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    player1score++;
                    labelPlayer1Score.Text = ($"PLayer 1 score: {player1score}");
                }
                CheckForDraw();

            }

        }
        public void Reset()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn1.BackColor = System.Drawing.Color.White;
            btn2.BackColor = System.Drawing.Color.White;
            btn3.BackColor = System.Drawing.Color.White;
            btn4.BackColor = System.Drawing.Color.White;
            btn5.BackColor = System.Drawing.Color.White;
            btn6.BackColor = System.Drawing.Color.White;
            btn7.BackColor = System.Drawing.Color.White;
            btn8.BackColor = System.Drawing.Color.White;
            btn9.BackColor = System.Drawing.Color.White;
            gameBoard = new string[9];
            currentTurn = 0;

        }
        public void changeColor(int number)
        {
            switch (number)
            {
                case 0:
                    btn1.BackColor = System.Drawing.Color.Red;
                    break;
                case 1:
                    btn2.BackColor = System.Drawing.Color.Red;
                    break;
                case 2:
                    btn3.BackColor = System.Drawing.Color.Red;
                    break;
                case 3:
                    btn4.BackColor = System.Drawing.Color.Red;
                    break;
                case 4:
                    btn5.BackColor = System.Drawing.Color.Red;
                    break;
                case 5:
                    btn6.BackColor = System.Drawing.Color.Red;
                    break;
                case 6:
                    btn7.BackColor = System.Drawing.Color.Red;
                    break;
                case 7:
                    btn8.BackColor = System.Drawing.Color.Red;
                    break;
                case 8:
                    btn9.BackColor = System.Drawing.Color.Red;

                    break;
            }




        }
        public void CheckForDraw()
        {
            int counter = 0;
            for (int i = 0; i < gameBoard.Length; i++)
            {
                if (gameBoard[i] != null) { counter++; }

                if (counter == 9)
                {
                    Reset();
                    MessageBox.Show("Thats a draw!", "No winner today!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }


        }
        private void TTT_Load(object sender, EventArgs e)
        {
            label1.Text = Form2.users;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Font = new Font("Showcard Gothic", 14);
            currentTurn++;
            gameBoard[0] = ReturnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[0]);
            btn1.BackColor = buttonColor;
            btn1.Text = gameBoard[0];
            CheckForWinner();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Font = new Font("Showcard Gothic", 14);

            currentTurn++;
            gameBoard[1] = ReturnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[1]);
            btn2.BackColor = buttonColor;
            btn2.Text = gameBoard[1];
            CheckForWinner();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.Font = new Font("Showcard Gothic", 14);

            currentTurn++;
            gameBoard[2] = ReturnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[2]);
            btn3.BackColor = buttonColor;
            btn3.Text = gameBoard[2];
            CheckForWinner();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.Font = new Font("Showcard Gothic", 14);

            currentTurn++;
            gameBoard[3] = ReturnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[3]);
            btn4.BackColor = buttonColor;
            btn4.Text = gameBoard[3];
            CheckForWinner();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.Font = new Font("Showcard Gothic", 14);

            currentTurn++;
            gameBoard[4] = ReturnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[4]);
            btn5.BackColor = buttonColor;
            btn5.Text = gameBoard[4];
            CheckForWinner();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.Font = new Font("Showcard Gothic", 14);

            currentTurn++;
            gameBoard[5] = ReturnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[5]);
            btn6.BackColor = buttonColor;
            btn6.Text = gameBoard[5];
            CheckForWinner();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn7.Font = new Font("Showcard Gothic", 14);

            currentTurn++;
            gameBoard[6] = ReturnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[6]);
            btn7.BackColor = buttonColor;
            btn7.Text = gameBoard[6];
            CheckForWinner();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btn8.Font = new Font("Showcard Gothic", 14);

            currentTurn++;
            gameBoard[7] = ReturnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[7]);
            btn8.BackColor = buttonColor;
            btn8.Text = gameBoard[7];
            CheckForWinner();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.Font = new Font("Showcard Gothic", 14);

            currentTurn++;
            gameBoard[8] = ReturnSymbol(currentTurn);
            Color buttonColor = determineColor(gameBoard[8]);
            btn9.BackColor = buttonColor;
            btn9.Text = gameBoard[8];
            CheckForWinner();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The game is played on a grid that's 3 squares by 3 squares." +
                "You are X, your friend (or the computer in this case) is O. " +
                "Players take turns putting their marks in empty squares." +
                "The first player to get 3 of her marks in a row (up, down, across, or diagonally) is the winner." +
                "When all 9 squares are full, the game is over.", "Tic tac toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labelPlayer1Score_Click(object sender, EventArgs e)
        {

        }

        private void labelPlayer2Score_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
