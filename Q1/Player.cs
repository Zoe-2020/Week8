using System;
using System.Collections.Generic;
using System.Text;

namespace Q1
{
    public class Player
    {
        public int PlayerID { get; }
        public string PlayerName { get; set; }
        public int Score { get; private set; }

        public Player (int playerID,string playerName,int score)
        {
            PlayerID = playerID;
            PlayerName = playerName;
            Score = score;
        }
        public void IncreaseScore(int scoreValue)
        {
            Score += scoreValue;
        }
    }
}
