﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class ScoreBoard
    {
        int player1Score = 0;
        int player2Score = 0;

        public int getScorePlayer1()
        {
            return this.player1Score;
        }

        public int getScorePlayer2()
        {
            return this.player2Score;
        }
    }
}
