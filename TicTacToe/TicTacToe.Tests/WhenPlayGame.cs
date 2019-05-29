using NUnit.Framework;
using TicTacToe.Domain;

namespace TicTacToe.Tests
{
    public class WhenPlayGame
    {
        [Test]
        public void CanPlay_X_At_1_1()
        {
            var game = new TicTacToeGame();

            game.Play(new Cell("X"), new Row(1), new Column(1));

            var field = game.Field();
            Assert.AreEqual(new Field(
                "X  ",
                "   ",
                "   "), field);
        }
    }
}