using NUnit.Framework;
using PingPongGameW59276;

namespace Pong
{
    [TestFixture]
    class ballTest
    {
        [Test]
        public void scoreTestInitialScoreShouldBeZero()
        {
            Player player = new Player();
            Assert.AreEqual(0, player.score);
        }
    }
}

