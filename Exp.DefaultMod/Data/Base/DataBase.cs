namespace Exp.DefaultMod {
    internal abstract class DataBase : Data.IDataBase {
        #region Properties / Felder
        /// <summary>Eindeutige Identifizierung des Items.</summary>
        public string ID { get; init; }
        /// <summary>Sprachabhäniger Name des Items.</summary>
        public Util.LanguageBasedData Name { get; } = new Util.LanguageBasedData();
        /// <summary>Sprachabhänige Beschreibung des Items.</summary>
        public Util.LanguageBasedData Description { get; } = new Util.LanguageBasedData();
        /// <summary>Sortierreihenfolge.</summary>
        public int SortWeight { get; set; }
        #endregion

        #region Konstruktor
        private protected DataBase(string aID, int aSortWeight)
            => (ID, SortWeight) = (aID, aSortWeight);
        #endregion
    }
}