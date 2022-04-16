using System.Reflection;

namespace Exp.Data {
    public abstract class DataBase {
        #region Properties / Felder
        /// <summary>Eindeutige Identifizierung des Items.</summary>
        public string ID { get; init; }
        /// <summary>Name des Items.</summary>
        public string Name { get; set; }
        /// <summary>Beschreibung des Items.</summary>
        public string Description { get; set; }
        /// <summary>Sortierreihenfolge.</summary>
        public int SortWeight { get; set; }
        #endregion

        #region Konstruktor
        protected DataBase(string aID, int aSortWeight)
            => (ID, Name, Description, SortWeight) = (aID, string.Empty, string.Empty, aSortWeight);
        #endregion
    }
}