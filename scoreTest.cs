using NUnit.Framework;
using PingPongGameW59276;


namespace Pong
{
    [TestFixture]
    class scoreTest
    {



        [Test]
        public void scoreTestBallShouldAddToScore()
        {
            Player player = new Player();
            Ball ball = new Ball();
            ball.Score(player);

            Assert.AreEqual(1, player.score);
        }

    }
}
