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
    public partial class RPS : Form
    {
        Random random = new Random();
        public RPS()
        {
            InitializeComponent();
        }
        int screComputer = 0;
        int scoreYou = 0;
        private void btnPlay1_Click(object sender, EventArgs e)
        {
            

            int computerTurn =  random.Next(1, 4);
            int playerTurn = random.Next(1, 4);

            switch (computerTurn)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.rock;//rock
                
                    break;
                case 2:
                    pictureBox1.Image=Properties.Resources.paper;//paper
                   
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.pngwing_com__3_;
                    break;
                default:
                    pictureBox1.Image = Properties.Resources.rock;
                    break;
            }
            switch (playerTurn)
            {

                case 1:
                    pictureBox2.Image = Properties.Resources.rock;
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.paper;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources.pngwing_com__3_;
                    break;
                default:
                    pictureBox2.Image = Properties.Resources.rock;
                    break;
            }
            determWinner(computerTurn, playerTurn);
        }

        private void determWinner(int computerScore, int playerScore)
        {
            
      
                if (computerScore == 1 && playerScore == 2)
                {
                    
                    MessageBox.Show("The Computer has won the game!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    screComputer++;
                    labelComputerScore.Text = ($"Computer's score: {screComputer}");
                }
                else if (computerScore == 1 && playerScore == 3)//rock>scissors
                {
                    
                    MessageBox.Show("The Computer has won the game!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    screComputer++;
                    labelComputerScore.Text = ($"Computer's score: {screComputer}");
                }
                else if (computerScore == 2 && playerScore == 1)
                {
                   
                    MessageBox.Show("You has won the game!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreYou++;
                    labelPlayer2Score.Text = ($"Your  score: {scoreYou}");

                }
                else if (computerScore == 2 && playerScore == 3)
                {
                    
                    MessageBox.Show("You has won the game!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scoreYou++;
                    labelPlayer2Score.Text = ($"Your  score: {scoreYou}");

                }
                else if (computerScore == 3 && playerScore == 1)
                {
                scoreYou++;
                    MessageBox.Show("You has won the game!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labelPlayer2Score.Text = ($"Your  score: {scoreYou}");

                }
                else if (computerScore == 3 && playerScore == 2)
                {
                    MessageBox.Show("The Computer has won the game!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    screComputer++;
                    labelComputerScore.Text = ($"Computer's score: {screComputer}");
                }
                else
                {
                    MessageBox.Show("Thats a draw!", "No winner today!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The players may count aloud to three, or speak the name of the game (e.g. Rock Paper! Scissors!), either raising one hand in a fist and swinging it down with each syllable or holding it behind their back. " +
                "They then throw  by extending it towards their opponent. Variations include a version where players throw immediately on the third count (thus throwing on the count of Scissors!)," +
                " or a version where they shake their hands three times before throwing.", "Rock,Paper,Scissors", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RPS_Load(object sender, EventArgs e)
        { 
            lblUser.Text = Form2.users;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            scoreYou = 0;
            screComputer = 0;
            labelPlayer2Score.Text = string.Empty;
            labelComputerScore.Text = string.Empty;
            pictureBox1.Image =null;
            pictureBox2.Image = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }
    }
}

