namespace TicTacToe.Domain
{
    public class TicTacToeGame
    {
        public Field Field(string row1, string row2, string row3)
        {
            return new Field(row1, row2, row3);
        }
    }
}