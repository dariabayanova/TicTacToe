namespace TicTacToe.Domain
{
    public class TicTacToeGame
    {
        public Field Field()
        {
            return new Field();
        }
    }

    public class Field
    {
        public string GetCell(int row, int column)
        {
            return " ";
        }
    }
}