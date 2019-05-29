using NUnit.Framework;

namespace Tests
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

    public class TicTacToeGame
    {
        public string[,] Field()
        {
            var field = new string[3, 3];

            field[1, 1] = " ";
            
            return field;
        }
    }
}