namespace Exp.Api.General {
    public sealed class DiceType : ApiBase<Data.General.DiceTypeData> {
        #region Properties / Felder
        private static readonly DiceType mSingleton = new();
        #endregion

        #region Konstruktor
        internal DiceType() : base() {
            Add("W4", 4, 100);
            Add("W6", 6, 200);
            Add("W8", 8, 300);
            Add("W10", 10, 400);
            Add("W12", 12, 500);
            Add("W20", 20, 600);
            Add("W100", 100, 700);
        }
        #endregion

        #region Methoden
        public static DiceType Singleton {
            get {
                return mSingleton;
            }
        }

        public void Add(string aID, int aFaces, int aSortWeight = 0) {
            base.Add(new Data.General.DiceTypeData(aID, aSortWeight, aFaces));
        }
        #endregion
    }
}