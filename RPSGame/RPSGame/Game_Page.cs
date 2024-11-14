using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Kushal Patel
//This program plays a rock apaper scissor game with player vs computer and shows result who wins and this game has property to save player profile and can be filled automataically after first game.

namespace RPSGame
{
    public partial class Game_Page : Form
    {
        private string namePlayer;
        private int numberRound, constRound;
        private bool gameOver = false;
        private int timerRound = 6;
        private string[] cypherChoice = { "Rock", "Paper", "Scissor", "Paper", "Rock", "Scissor" };
        int randomGenrator = 0;
        Random selected = new Random();
        private string cypherSelected;
        private string playerSelected;
        private int cypherPoints;
        private int playerPoints;
        public Game_Page(string playerName, int rounds)
        {   
            InitializeComponent();
            playerNameLabel.Text = playerName + " :";
            playerChoice.Text = playerName + " Choice";
            this.namePlayer = playerName;
            this.numberRound = rounds;

            countDown.Enabled = true;
            timerLabel.Text = "5";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you have saved your profile just enter firstname and click view profile to get you your other data filled automatically and change if you want change something and start game again.");
            Home_Page home_Page = new Home_Page();
            home_Page.Show();
            this.Hide();
        }

        private void RockButton_Click(object sender, EventArgs e)
        {
            playerImage.Image = Properties.Resources.rocks;
            playerSelected = "Rock";

        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            playerImage.Image = Properties.Resources.papers;
            playerSelected = "Paper";
        }

        private void ScissorButton_Click(object sender, EventArgs e)
        {
            playerImage.Image = Properties.Resources.scissors;
            playerSelected = "Scissor";
        }

        

        private void countDown_Tick(object sender, EventArgs e)
        {
            timerRound--;
            timerLabel.Text = timerRound.ToString();
            countLabel.Text =  numberRound + ""; 
            if (timerRound < 1)
            {
                countDown.Enabled = false;
                timerRound = 6;
                randomGenrator = selected.Next(0,cypherChoice.Length);
                cypherSelected = cypherChoice[randomGenrator].ToLower();
                switch(cypherSelected)
                {
                    case "rock":
                        cypherImage.Image = Properties.Resources.rocks;
                        break;
                    case "paper":
                         cypherImage.Image = Properties.Resources.papers;
                        break;
                    case "scissor":
                         cypherImage.Image = Properties.Resources.scissors;
                        break;
                    default:
                        break;
                }
                if (numberRound > 0)
                    checkGame();
                else
                {
                    if (playerPoints >= cypherPoints)
                    {
                        MessageBox.Show("Game Over\r\n\r"+namePlayer + " Wins The RPS Game, Congratsssss!!!!!!\r\nIf you want to play again with same number of round then press restsart\r\n If you want to play more round then Go back and start change the number of round.");
                    }
                    else
                    {
                        MessageBox.Show("Game Over\r\n\rYou Lose!!!!!!!, Cypher wins the game.\r\nIf you want to play again with same number of round then press restsart\r\n If you want to play more round then Go back and start change the number of round.");
                    }
                    gameOver = true;
                }
            }
           
        }

        private void checkGame()
        {
            playerSelected = playerSelected.ToLower();
            if(playerSelected =="rock" && cypherSelected == "paper")
            {
                cypherPoints += 1;
                numberRound -= 1;
                MessageBox.Show("Cypher Wins, Paper covers Rock");
            }
            else if (playerSelected == "rock" && cypherSelected == "scissor")
            {
                playerPoints += 1;
                numberRound -= 1;
                MessageBox.Show(namePlayer + " Wins, Rock breaks Scissor");
            }
             else if (playerSelected == "paper" && cypherSelected == "scissor")
            {
               cypherPoints += 1;
                numberRound -= 1;
                MessageBox.Show("Cypher Wins, Scissor cuts Paper");
            }
            else if (playerSelected == "paper" && cypherSelected == "rock")
            {
                playerPoints += 1;
                numberRound -= 1;
                MessageBox.Show(namePlayer + " Wins, Paper covers Rock");
            }
            else if (playerSelected == "scissor" && cypherSelected == "rock")
            {
                cypherPoints += 1;
                numberRound -= 1;
                MessageBox.Show("Cypher Wins, Rock breaks Scissor");
            }
            else if (playerSelected == "scissor" && cypherSelected == "paper")
            {
                playerPoints += 1;
                numberRound -= 1;
                MessageBox.Show(namePlayer + " Wins, Scissor Cuts Paper");
            }
            else if (playerSelected == "None")
            {
                MessageBox.Show(namePlayer + " Make a Choice To Play");
            }
            else 
            {
                MessageBox.Show("Both Selected Same, Match Draw!!!!!!!");
            }
            nextRound();
        }

        private void nextRound()
        {
            if (gameOver == true)
                return;
            PlayerScoreLabel.Text = playerPoints + "";
            cypherScoreLabel.Text = cypherPoints + "";
            playerSelected = "none";
            countDown.Enabled = true;
            playerImage.Image = Properties.Resources.questionMark;
            cypherImage.Image = Properties.Resources.questionMark;           
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            playerPoints = 0;
            cypherPoints = 0;
            countLabel.Text = numberRound + "";
            PlayerScoreLabel.Text = playerPoints + "";
            cypherScoreLabel.Text = cypherPoints + "";
            countDown.Enabled = true;
            playerImage.Image = Properties.Resources.questionMark;
            cypherImage.Image = Properties.Resources.questionMark;
            gameOver = false;

        }
    }
}
