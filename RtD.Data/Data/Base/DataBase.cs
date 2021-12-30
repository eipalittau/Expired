namespace RtD.Data
{
    public abstract class DataBase
    {
        #region Properties / Felder
        public long ID { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public uint SortOrder { get; set; }
        #endregion

        #region Konstruktor
        protected DataBase(long aID)
            : this(aID, string.Empty, string.Empty, 0) { }

        protected DataBase(long aID, string? aName, string? aDescription)
            : this(aID, aName, aDescription, 0) { }

        protected DataBase(long aID, string? aName, string? aDescription, uint aSortOrder)
            => (ID, Name, Description, SortOrder) = (aID, aName ?? string.Empty, aDescription ?? string.Empty, aSortOrder);
        #endregion
    }
}