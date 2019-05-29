namespace TicTacToe.Domain
{
    public class Coordinate
    {
        private readonly Row row;
        private readonly Column column;

        public Coordinate(Row row, Column column)
        {
            this.row = row;
            this.column = column;
        }

        #region EqulityMember

        protected bool Equals(Coordinate other)
        {
            return Equals(row, other.row) && Equals(column, other.column);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Coordinate) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((row != null ? row.GetHashCode() : 0) * 397) ^ (column != null ? column.GetHashCode() : 0);
            }
        }
        
        public static bool operator == (Coordinate coordinate1, Coordinate coordinate2)
        {
            if (ReferenceEquals(coordinate1, null) || ReferenceEquals(coordinate2, null))
                return false;
            return coordinate1.Equals(coordinate2);
        }

        public static bool operator !=(Coordinate coordinate1, Coordinate coordinate2)
        {
            return !(coordinate1.Equals(coordinate2));
        }

        #endregion
    }
}