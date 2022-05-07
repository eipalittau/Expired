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

        #region Methoden
        protected static void AddInstance(ITierData aInstance) {
            Api.General.Tier.Singleton.Add(aInstance);
        }
        #endregion
    }
}