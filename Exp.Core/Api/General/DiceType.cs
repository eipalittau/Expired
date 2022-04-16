namespace Exp.Api.General {
    public sealed class DiceType : ApiBase<Data.General.DiceTypeData> {
        #region Properties / Felder
        private static readonly DiceType mSingleton = new();
        #endregion

        #region Konstruktor
        internal DiceType() : base() {
            Add("W4", 100, 4, string.Empty);
            Add("W6", 200, 6, string.Empty);
            Add("W8", 300, 8, string.Empty);
            Add("W10", 400, 10, string.Empty);
            Add("W12", 500, 12, string.Empty);
            Add("W20", 600, 20, string.Empty);
            Add("W100", 700, 100, string.Empty);
        }
        #endregion

        #region Methoden
        public static DiceType Singleton
        {
            get
            {
                return mSingleton;
            }
        }

        public void Add(string aID, int aFaces, int aSortWeight = 0) {
            Add(aID, aSortWeight, aFaces, base.GetOriginNameCaller());
        }
        // Patrik: Testen: Wert aus GetCallingAssembly wenn Daten aus Konstruktor.

        private void Add(string aID, int aSortWeight, int aFaces, string aOrigin) {
            base.Add(new Data.General.DiceTypeData(aID, aSortWeight, aOrigin, aFaces));
        }
        #endregion
    }
}