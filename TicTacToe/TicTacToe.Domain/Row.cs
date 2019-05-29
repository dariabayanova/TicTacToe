namespace TicTacToe.Domain
{
    public class Row
    {
        private readonly int row;

        public Row(int row)
        {
            this.row = row;
        }

        #region Equality members

        protected bool Equals(Row other)
        {
            return row == other.row;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Row) obj);
        }

        public override int GetHashCode()
        {
            return row;
        }

        #endregion
    }
}