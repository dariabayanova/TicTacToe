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
            var cell_1_1 = new Coordinate(new Row(1), new Column(1));
            
            game.Play(new Cell("X"), cell_1_1);

            var field = game.Field();
            Assert.AreEqual(new Field(
                "X  ",
                "   ",
                "   "), field);
        }

        [Test]
        public void CanPlay_X_At_1_2()
        {
            var game = new TicTacToeGame();
            var cell_1_2 = new Coordinate(new Row(1), new Column(2));
            
            game.Play(new Cell("X"), cell_1_2);
            
            var field = game.Field();
            Assert.AreEqual(new Field(
                            " X ",
                            "   ",
                            "   "), field);
        }

        [Test]
        public void CanPlay_X_At_1_3()
        {
            var game = new TicTacToeGame();
            var cell_1_3 = new Coordinate(new Row(1), new Column(3));
            
            game.Play(new Cell("X"), cell_1_3);
            
            var field = game.Field();
            Assert.AreEqual(new Field(
                "  X",
                "   ",
                "   "), field);
        }
    }
}