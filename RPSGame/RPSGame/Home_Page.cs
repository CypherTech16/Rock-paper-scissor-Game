using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Kushal Patel
//This program plays a rock apaper scissor game with player vs computer and shows result who wins and this game has property to save player profile and can be filled automataically after first game.


namespace RPSGame
{
    public partial class Home_Page : Form
    {
        private entrys newGame;
        private data profiles;
        public Home_Page()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (PlayerNameInput.Text.CompareTo("") == 0)
                newGame = new entrys();
            else
                newGame = new entrys(PlayerNameInput.Text, lastNameInput.Text, phoneNumberInput.Text ,Int32.Parse(roundsInput.Text));

            MessageBox.Show("Instructions for Rock-Paper-Scissors:\r\n\r\n1. Understand the Basics: Know that Rock beats Scissors, Scissors beat Paper, and Paper beats Rock.\r\n2. Choose Wisely: Select your move carefully, considering your opponent's likely choice.\r\n3. Be Aware of Ties: In case both players choose the same item, it's a tie, and the game continues.\r\n4. Enjoy the Game: Have fun and embrace the unpredictability of each round.");

            Game_Page game_Page = new Game_Page(newGame.playerName, newGame.Rounds);
            game_Page.Show();
            this.Hide();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void saveProfileButton_Click(object sender, EventArgs e)
        {
            profiles = new data();
            profiles.firstName = PlayerNameInput.Text;
            profiles.lastName = lastNameInput.Text;
            profiles.number = phoneNumberInput.Text;
            profiles.roundsPlayed = Int32.Parse(roundsInput.Text);

            FileStream output = new FileStream("C:\\Users\\WinBook\\Desktop\\RPSGame\\RPSGame\\Profiles\\" + profiles.firstName + ".txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(output, profiles);
            output.Close();

            MessageBox.Show("Welcome to Game, Your Profile has been Created.");
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            FileStream input = new FileStream("C:\\Users\\WinBook\\Desktop\\RPSGame\\RPSGame\\Profiles\\" + PlayerNameInput.Text + ".txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            profiles = (data)formatter.Deserialize(input);
            lastNameInput.Text = profiles.lastName;
            phoneNumberInput.Text = profiles.number;
            roundsInput.Text = profiles.roundsPlayed + "";
            input.Close();
        }
    }
}
