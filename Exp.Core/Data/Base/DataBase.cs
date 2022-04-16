using System.Reflection;

namespace Exp.Data {
    public abstract class DataBase {
        #region Properties / Felder
        /// <summary>Eindeutige Identifizierung des Items.</summary>
        public string ID { get; init; }
        /// <summary>Name des Items. Der Name muss Unique sein.</summary>
        public string Name { get; set; }
        /// <summary>Beschreibung des Items.</summary>
        public string Description { get; set; }
        /// <summary>Sortierreihenfolge.</summary>
        public int SortWeight { get; set; }
        /// <summary>Name des Mods, welcher dieses Item erstellt hat.</summary>
        internal string Origin { get; init; }
        #endregion

        #region Konstruktor
        protected DataBase(string aID, string aName, string aOrigin)
            : this(aID, aName, string.Empty, aOrigin) { }

        protected DataBase(string aID, string aName, string aDescription, string aOrigin)
            : this(aID, aName, aDescription, 0, aOrigin) { }

        protected DataBase(string aID, string aName, string aDescription, int aSortWeight, string aOrigin)
        {
            if (string.IsNullOrWhiteSpace(aOrigin))
            {
                aOrigin = Assembly.GetExecutingAssembly().GetName().Name ?? string.Empty;
            }

            ID = aID;
            Name = aName;
            Description = aDescription;
            SortWeight = aSortWeight;
            Origin = aOrigin;
        }
        #endregion
    }
}