namespace TicTacToe.Domain
{
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