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

            Assert.AreEqual(new Cell(" "), field.GetCell(new Row(1), new Column(1)));
        }
    }
}