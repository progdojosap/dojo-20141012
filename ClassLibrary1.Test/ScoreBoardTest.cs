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
        [Test]
        public void ScoreBoardを生成した直後Player1のスコアは0である()
        {
            int expected = 0;
            int actual = new ScoreBoard().getScorePlayer1();
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void ScoreBoardを生成した直後Player2のスコアは0である()
        {
            int expected = 0;
            int actual = new ScoreBoard().getScorePlayer2();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test][Ignore]
        public void ScoreBoardを生成した直後にPlayer1にwonPointを実行すると1()
        {
            int expected = 1;
            ScoreBoard target = new ScoreBoard();
            target.WonPoint(Player.Player1);
            Assert.That(target.getScorePlayer1(), Is.EqualTo(expected));  
        }

        [Test]
        public void ScoreBoardを生成した直後にPlayer2にwonPointを実行すると1()
        {
            int expected = 1;
            ScoreBoard target = new ScoreBoard();
            target.WonPoint(Player.Player2);
            Assert.That(target.getScorePlayer2(), Is.EqualTo(expected));
        }

        [Test]
        public void player1が指定された場合player1のスコアが１増える()
        {

            int expected = 3;
            ScoreBoard target = new ScoreBoard();
            target.WonPoint(Player.Player1);
            target.WonPoint(Player.Player1);
            target.WonPoint(Player.Player1);
            
            int actual = target.getScorePlayer1();
            Assert.That(actual, Is.EqualTo(expected));
            
        }
      
    }
}
