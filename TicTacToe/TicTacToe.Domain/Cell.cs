namespace TicTacToe.Domain
{
    public class Cell
    {
        private readonly string state;

        public Cell(string state)
        {
            this.state = state;
        }

        #region Equality members

        protected bool Equals(Cell other)
        {
            return string.Equals(state, other.state);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Cell) obj);
        }

        public override int GetHashCode()
        {
            return (state != null ? state.GetHashCode() : 0);
        }

        #endregion
    }
}