using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Kushal Patel
//Class 1 used to take entry of player for first game and forward it to home and game page.

namespace RPSGame
{
    internal class entrys
    {
        public string playerName { get; set; }
        public string playerLastName { get; set; }
        public string phoneNumber { get; set; }
        private int numberRounds;
        public int Rounds
        {
            get
            {
                return numberRounds;
            }
            set
            {
                if (value > 0)
                    numberRounds = value;
            }
        }

        public entrys(string Name, string Lname, string phone_Number, int Rounds) 
        {
            playerName = Name;
            playerLastName = Lname;
            phoneNumber = phone_Number;
            numberRounds = Rounds;
        }

        public entrys() 
        {
            playerName = "Adian";
            playerLastName = "James";
            phoneNumber = "998767336" ;
            numberRounds = 4;
        }
    }
}
