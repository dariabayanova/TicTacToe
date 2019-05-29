using NUnit.Framework;
using TicTacToe.Domain;

namespace TicTacToe.Tests
{
    public class WhenCreateGame
    {
        [Test]
        public void FieldIsEmpty()
        {
            var game = new TicTacToeGame();

            var field = game.Field();

            Assert.AreEqual(" ", field[1, 1]);
        }
    }
}