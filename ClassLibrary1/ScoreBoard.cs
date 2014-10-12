using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public enum Player
    {
        Player1,
        Player2
    }

    public class ScoreBoard
    {
        int player1Score = 0;
        int player2Score = 0;

        public int getScorePlayer(Player player)
        {
            if (Player.Player1 == player) {
                return this.player1Score;
            }
            else
            {
                return this.player2Score;
            }

        }

        public void WonPoint(Player player)
        {

            player1Score++;
            player2Score++;

        }
    }
}
