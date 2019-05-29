using NUnit.Framework;
using TicTacToe.Domain;

namespace TicTacToe.Tests
{
    public class WhenCreateGame
    {
        [Test]
        public void Cell_1_1_IsEmpty()
        {
            var game = new TicTacToeGame();
            var field = game.Field();
            
            var cellAt_1_1 = field.GetCell(new Row(1), new Column(1));
            
            var emptyCell = new Cell(" ");
            Assert.AreEqual(emptyCell, cellAt_1_1);
        }

        [Test]
        public void Cell_1_2_IsEmpty()
        {
            var field = new TicTacToeGame().Field();
            
            var cellAt_1_2 = field.GetCell(new Row(1), new Column(2));
            
            var emptyCell = new Cell(" ");
            Assert.AreEqual(emptyCell, cellAt_1_2);
        }
    }
}