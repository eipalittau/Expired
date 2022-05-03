namespace Exp.Data.General {
    public abstract class TierBase : DataBase {
        #region Properties / Felder
        public int Tier { get; set; }
        #endregion

        #region Konstruktor
        protected TierBase(string aID, int aSortWeight, int aTier)
            : base(aID, aSortWeight)
            => Tier = aTier;
        #endregion
    }
}