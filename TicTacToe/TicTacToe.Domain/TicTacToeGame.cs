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
            field = new Field("X  ", "   ", "   ");
        }
    }
}