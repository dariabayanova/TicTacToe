namespace TicTacToe.Domain
{
    public class Column
    {
        private readonly int column;

        public Column(int column)
        {
            this.column = column;
        }

        #region Equality members

        protected bool Equals(Column other)
        {
            return column == other.column;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Column) obj);
        }

        public override int GetHashCode()
        {
            return column;
        }

        #endregion
    }
}