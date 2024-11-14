using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Kushal Patel
//Class 2 which used to save player data that has benn filled.

namespace RPSGame
{
    [Serializable]
    internal class data
    {
        public string firstName { get; set; }
        public string lastName { get; set; }  
        public string number { get; set; }
        public int roundsPlayed { get; set; }
    }
}
