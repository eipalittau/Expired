namespace Exp.Data {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public abstract class DataBase {
        #region Properties / Felder
        /// <summary>Eindeutige Identifizierung des Items.</summary>
        public string ID { get; init; }
        /// <summary>Sprachabhäniger Name des Items.</summary>
        public Util.LanguageBasedData Name { get; } = new Util.LanguageBasedData();
        /// <summary>Sprachabhänige Beschreibung des Items.</summary>
        public Util.LanguageBasedData LoreDescription { get; } = new Util.LanguageBasedData();
        /// <summary>Sortierreihenfolge.</summary>
        public int SortWeight { get; set; }
        #endregion

        #region Konstruktor
        protected DataBase(string aID, int aSortWeight)
            => (ID, SortWeight) = (aID, aSortWeight);
        #endregion
    }
}