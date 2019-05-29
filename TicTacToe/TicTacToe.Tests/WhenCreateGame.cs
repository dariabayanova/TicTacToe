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
            var field = game.Field( "   ",
                                    "   ",
                                    "   ");

            var emptyField = new Field(  "   ",
                                        "   ",
                                        "   ");
            Assert.AreEqual(emptyField, field);
        }
    }
}