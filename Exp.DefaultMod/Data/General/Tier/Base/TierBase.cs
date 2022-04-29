namespace Exp.DefaultMod.General.Tier {
    public abstract class TierBase : DataBase, Data.General.ITierDataBase {
        #region Properties / Felder
        public int Tier { get; set; }
        #endregion

        #region Konstruktor
        private protected TierBase(string aID, int aSortWeight, int aTier)
            : base(aID, aSortWeight)
            => Tier = aTier;
        #endregion
    }
}