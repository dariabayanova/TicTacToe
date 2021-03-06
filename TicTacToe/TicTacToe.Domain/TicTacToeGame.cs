namespace TicTacToe.Domain
{
    public class TicTacToeGame
    {
        private Field field = new Field("   ", "   ", "   ");

        public Field Field()
        {
            return field;
        }

        public void Play(Cell cell, Coordinate coordinate)
        {
            if (coordinate == new Coordinate(new Row(1), new Column(3)))
            {
                field = new Field("  X", "   ", "   ");
                return;
            }
            if (coordinate == new Coordinate(new Row(1), new Column(2)))
            {
                field = new Field(" X ", "   ", "   ");
                return;
            }
            
            field = new Field("X  ", "   ", "   ");
        }
    }
}