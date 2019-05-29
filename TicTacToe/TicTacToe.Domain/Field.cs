namespace TicTacToe.Domain
{
    public class Field
    {
        private readonly string row1;
        private readonly string row2;
        private readonly string row3;

        public Field(string row1, string row2, string row3)
        {
            this.row1 = row1;
            this.row2 = row2;
            this.row3 = row3;
        }

        public Cell GetCell(Row row, Column column)
        {
            return new Cell(" ");
        }

        #region Equlity members

        protected bool Equals(Field other)
        {
            return string.Equals(row1, other.row1) && string.Equals(row2, other.row2) && string.Equals(row3, other.row3);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Field) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (row1 != null ? row1.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (row2 != null ? row2.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (row3 != null ? row3.GetHashCode() : 0);
                return hashCode;
            }
        }

        #endregion
    }
}