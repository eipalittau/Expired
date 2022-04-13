namespace Exp.Data {
    public abstract class DataBase {
        #region Properties / Felder
        /// <summary>Eindeutige Identifizierung des Items.</summary>
        public int ID { get; init; }
        /// <summary>Name des Items. Der Name muss Unique sein.</summary>
        public string Name { get; set; }
        /// <summary>Beschreibung des Items.</summary>
        public string Description { get; set; }
        /// <summary>Sortierreihenfolge.</summary>
        public uint SortOrder { get; set; }
        /// <summary>Name des Mods, welcher dieses Item erstellt hat.</summary>
        internal string Origin { get; init; }
        #endregion

        #region Konstruktor
        protected DataBase(int aID, string aName, string aOrigin)
            : this(aID, aName, string.Empty, aOrigin) { }

        protected DataBase(int aID, string aName, string aDescription, string aOrigin)
            : this(aID, aName, aDescription, 0, aOrigin) { }

        protected DataBase(int aID, string aName, string aDescription, uint aSortOrder, string aOrigin)
            => (ID, Name, Description, SortOrder, Origin) = (aID, aName, aDescription, aSortOrder, aOrigin);
        #endregion
    }
}