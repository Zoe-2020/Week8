using System;
using System.Collections.Generic;
using System.Text;

namespace Q1
{
    public class Player:IComparable
    {
        public int PlayerID { get; }
        public string PlayerName { get; set; }
        public int Score { get; private set; }

        public static int higheScore  { get; private set; }

        public Player (int playerID,string playerName,int score)
        {
            PlayerID = playerID;
            PlayerName = playerName;
            Score = score;
        }
        public void IncreaseScore(int scoreValue)
        {
            Score += scoreValue;

            if (Score > higheScore)
                higheScore = Score;
        }
        public override string ToString()
        {
            return PlayerID+"\t"+ PlayerName + "\t" + Score;
        }

        public int CompareTo(object obj)
        {
            Player objectThatsComparedto = obj as Player;
            int returnValue = this.Score.CompareTo(objectThatsComparedto.Score);
            return returnValue;
        }
    }
}
