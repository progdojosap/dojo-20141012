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
        public void ScoreBoardを生成した直後Playerのスコアは0である()
        {
            int expected = 0;
            int actual = new ScoreBoard().getScorePlayer1();
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
