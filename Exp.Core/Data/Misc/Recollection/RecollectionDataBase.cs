namespace Exp.Data.Misc.Recollection {
    public abstract class RecollectionDataBase : DataBase {
        #region Properties / Felder
        public int DiceStart { get; }
        public int DiceEnd { get; }
        #endregion

        #region Konstruktor
        protected RecollectionDataBase(string aID, int aSortWeight, int aDiceStart, int aDiceEnd)
            : base(aID, aSortWeight)
            => (DiceStart, DiceEnd) = (aDiceStart, aDiceEnd);

        #endregion

        #region Methoden
        protected static void AddInstance(IRecollectionData aInstance) {
            Api.Misc.Recollection.Singleton.Add(aInstance);
        }
        #endregion
    }
}