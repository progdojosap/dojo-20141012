using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Test
{
    [TestFixture]
    public class ScoreBoardTest
    {
        [TestCase(Player.Player1)]
        [TestCase(Player.Player2)]
        public void ScoreBoardを生成した直後Playerのスコアは0である(Player player)
        {
            int expected = 0;
            int actual = new ScoreBoard().getScorePlayer(player);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(Player.Player1)]
        [TestCase(Player.Player2)]
        public void ScoreBoardを生成した直後にPlayerにwonPointを実行すると1(Player player)
        {
            int expected = 1;
            ScoreBoard target = new ScoreBoard();
            target.WonPoint(player);
            Assert.That(target.getScorePlayer(player), Is.EqualTo(expected));  
        }

        [TestCase(Player.Player1)]
        [TestCase(Player.Player2)]
        public void player1が指定された場合player1のスコアが１増える(Player player)
        {
            int expected = 3;
            ScoreBoard target = new ScoreBoard();
            target.WonPoint(player);
            target.WonPoint(player);
            target.WonPoint(player);

            int actual = target.getScorePlayer(player);
            Assert.That(actual, Is.EqualTo(expected));
        }

        
      
    }
}
