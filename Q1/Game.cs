using System;
using System.Collections.Generic;
using System.Linq;

namespace Q1
{
    class Game
    {
        static void Main(string[] args)
        {
            List<Player> teamPlayers = new List<Player>();
            Player player1 = new Player(1, "Millie", 0);
            Player player2 = new Player(2, "Katie", 0);
            Player player3 = new Player(3, "Kevin", 0);
            Player player4 = new Player(4, "Conor", 0);
            Player player5 = new Player(5, "Pauline", 0);

            teamPlayers.Add(player1);
            teamPlayers.Add(player2);
            teamPlayers.Add(player3);
            teamPlayers.Add(player4);
            teamPlayers.Add(player5);

            player1.IncreaseScore(4);
            player2.IncreaseScore(10);
            player3.IncreaseScore(27);
            player4.IncreaseScore(8);
            player5.IncreaseScore(5);

            Display(teamPlayers);
            teamPlayers.Sort();
           

            Console.WriteLine("\n what player would you like to add scores too?");
            int PlayerNum = int.Parse(Console.ReadLine());

            while (PlayerNum != 0)
            {
                Player selectedPlayer = teamPlayers.ElementAt(PlayerNum-1);

                selectedPlayer.IncreaseScore(1);

                Display(teamPlayers);

                Console.WriteLine("\n what player would you like to add scores too?");
                PlayerNum = int.Parse(Console.ReadLine());

            }
            DisplayPlayerDetails(teamPlayers);
            Console.WriteLine("the highest score is {0}", Player.higheScore);


        }

         private static void Display(List<Player> players)
        {
           Console.WriteLine("{0,15}{1,15}{2,15}{3,15}{4,15}", "player 1", "player 2", "player 3", "player 4", "player 5");

           foreach (Player player in players)
           {
            Console.Write("{0,15}", player.Score);
           }

            
        }
        private static void DisplayPlayerDetails(List<Player> players)
        {
            Console.WriteLine($"{"ID"}\t{"Name"}\t{"Score"}");
            foreach(Player player in players)
            {
                Console.Write("{0}\n",player);
            }
        }
    }
}
