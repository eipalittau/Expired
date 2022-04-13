using System.Reflection;

namespace Exp.Api.General {
    public sealed class DiceType : Base<Data.General.DiceTypeData> {
        #region Konstruktor
        internal DiceType() : base() {
            string lOrigin = base.GetOriginNameExecuting();

            Add(1, "1W4", "4-seitiger Würfel", 1, lOrigin, 4);
            Add(2, "1W6", "6-seitiger Würfel", 2, lOrigin, 6);
            Add(3, "1W8", "8-seitiger Würfel", 3, lOrigin, 8);
            Add(4, "1W10", "10-seitiger Würfel", 4, lOrigin, 10);
            Add(5, "1W12", "12-seitiger Würfel", 5, lOrigin, 12);
            Add(6, "1W20", "20-seitiger Würfel", 6, lOrigin, 20);
            Add(7, "1W100", "100-seitiger Würfel", 7, lOrigin, 100);
        }
        #endregion

        #region Methoden
        public void Add(int aID, string aName, string aDescription, int aFaces) {
            Add(aID, aName, aDescription, (uint)base.Count() + 1, aFaces);
        }
        // Patrik: Testen: Wert aus GetCallingAssembly wenn Daten aus Konstruktor.
        public void Add(int aID, string aName, string aDescription, uint aSortOrder, int aFaces) {
            Add(aID, aName, aDescription, aSortOrder, base.GetOriginNameCaller(), aFaces);
        }

        private void Add(int aID, string aName, string aDescription, uint aSortOrder, string aOrigin, int aFaces) {
            if (base.ItemExists(aID, aName)) {
                // Patrik: Throw Dublicate Exception
            } else {
                base.Add(new Data.General.DiceTypeData(aID, aName, aDescription, aSortOrder, aOrigin, aFaces));
            }
        }
        #endregion
    }
}