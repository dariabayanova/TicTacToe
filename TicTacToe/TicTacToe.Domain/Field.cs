namespace TicTacToe.Domain
{
    public class Field
    {
        public Cell GetCell(Row row, Column column)
        {
            return new Cell(" ");
        }
    }
}